using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.WebClient.Interfaces;
using static IncidentManagement.WebClient.Pages.Incidents;

namespace IncidentManagement.WebClient.Services
{
    public class LookupCacheService : ILookupCacheService
    {
        private readonly IIncidentStatusService _incidentStatusService;
        private readonly IIncidentPriorityService _incidentPriorityService;
        private readonly IIncidentRoleService _incidentRoleService;
        private readonly IIncidentCategoryService _incidentCategoryService;
        private readonly IIncidentPropertyService _incidentPropertyService;
        private List<IncidentStatusResponse>? _statuses;
        private List<IncidentPriorityResponse>? _Priorities;
        private List<IncidentRoleResponse>? _Roles;
        private List<IncidentCategoryResponse>? _Categories;
        private List<IncidentPropertyResponse>? _Properites;

        public LookupCacheService(
        IIncidentStatusService incidentStatusService,
        IIncidentPriorityService incidentPriorityService,
        IIncidentRoleService incidentRoleService,IIncidentCategoryService incidentCategoryService,IIncidentPropertyService incidentPropertyService)
        {
            _incidentStatusService = incidentStatusService;
            _incidentPriorityService = incidentPriorityService;
            _incidentRoleService = incidentRoleService;
            _incidentCategoryService= incidentCategoryService;
            _incidentPropertyService = incidentPropertyService;
        }

        public async Task<List<IncidentPriorityResponse>> GetIncidentPrioritiesAsync()
        {
            if (_Priorities != null)
                return _Priorities;

            _Priorities = await _incidentPriorityService.GetPrioritiesAsync();

            return _Priorities;
        }

        public async Task<List<IncidentStatusResponse>> GetIncidentStatusesAsync()
        {
            if (_statuses != null)
                return _statuses;

            _statuses = await _incidentStatusService.GetStatusesAsync();

            return _statuses;
        }
        public async Task<List<IncidentRoleResponse>> GetIncidentRolesAsync()
        {
            if (_Roles != null)
                return _Roles;

            _Roles = await _incidentRoleService.GetRolesAsync();

            return _Roles;
        }

        public async Task<List<IncidentCategoryResponse>> GetIncidentCategoriesAsync()
        {
            if (_Categories != null)
                return _Categories;

            _Categories = await _incidentCategoryService.GetCategoriesAsync();

            return _Categories;   
        }
        public async Task<List<IncidentPropertyResponse>> GetIncidentPropertiesAsync()
        {
            if (_Properites != null)
                return _Properites;

            _Properites = await _incidentPropertyService.GetProperitesAsync();

            return _Properites;
        }
    }
}
