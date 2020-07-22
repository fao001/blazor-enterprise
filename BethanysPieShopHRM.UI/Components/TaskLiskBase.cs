using BethanysPieShopHRM.Shared;
using BethanysPieShopHRM.UI.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.UI.Components {
    public class TaskLiskBase : ComponentBase {
        [Inject]
        public ITaskDataService taskService { get; set; }

        [Inject]
        public NavigationManager navManager { get; set; }

        public List<HRTask> Tasks { get; set; } = new List<HRTask>();

        protected override async Task OnInitializedAsync() {
            Tasks = (await taskService.GetAllTasks()).ToList();
        }

        public void AddTask() {
            navManager.NavigateTo("taskedit");
        }
    }
}
