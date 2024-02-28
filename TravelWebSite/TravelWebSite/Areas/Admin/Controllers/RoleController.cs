using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travels_EntityLayer.Concrete;
using TravelWebSite.Areas.Admin.Models;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Role")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var values=_roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        [Route("CreateRole")]
        public IActionResult CreateRole() 
        {
            return View();
        }
        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole(CreateRoleVm createRoleVm)
        {
            AppRole role =new AppRole()
            {
                Name = createRoleVm.Name
            };
           var result=await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
           
        }
        [Route("DeleteRole/{Id}")]
        public async Task<IActionResult> DeleteRole(int Id)
        {
            var values=_roleManager.Roles.FirstOrDefault(x=>x.Id == Id);
            await _roleManager.DeleteAsync(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateRole/{Id}")]
        public IActionResult UpdateRole(int Id)
        {
            var values=_roleManager.Roles.FirstOrDefault(x=>x.Id==Id);
            UpdateRoleVm vm = new UpdateRoleVm
            {
                RoleId = values.Id,
                Name=values.Name
                
            };
            return View(vm);
        }
        [HttpPost]
        [Route("UpdateRole/{Id}")]
        public async Task<IActionResult> UpdateRole(UpdateRoleVm roleVm)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == roleVm.RoleId);
            value.Name=roleVm.Name;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }
        [Route("UserList")]
        public IActionResult UserList()
        {
            var values=_userManager.Users.ToList();
            return View(values);
        }
        [Route("AssignRole/{Id}")]
        [HttpGet]
        public async Task<IActionResult> AssignRole(int Id)
        {
            var user=_userManager.Users.FirstOrDefault(x=>x.Id==Id);
            TempData["Userid"] = user.Id;
            var roles=_roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);

            List<RoleAssignVm> roleAssignVms= new List<RoleAssignVm>();
            
            foreach(var item in roles)
            {
                RoleAssignVm model=new RoleAssignVm();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssignVms.Add(model);
            }
            return View(roleAssignVms);

        }
        [HttpPost]
        [Route("AssignRole/{Id}")]
        public async Task<IActionResult> AssignRole(List<RoleAssignVm> model)
        {
            var userId =(int)TempData["Userid"];
            var user=_userManager.Users.FirstOrDefault(x=>x.Id==userId);
            foreach(var item in model)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user,item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
