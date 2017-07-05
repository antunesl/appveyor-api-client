
var camelCaseTokenizer = function (obj) {
    var previous = '';
    return obj.toString().trim().split(/[\s\-]+|(?=[A-Z])/).reduce(function(acc, cur) {
        var current = cur.toLowerCase();
        if(acc.length === 0) {
            previous = current;
            return acc.concat(current);
        }
        previous = previous.concat(current);
        return acc.concat([current, previous]);
    }, []);
}
lunr.tokenizer.registerFunction(camelCaseTokenizer, 'camelCaseTokenizer')
var searchModule = function() {
    var idMap = [];
    function y(e) { 
        idMap.push(e); 
    }
    var idx = lunr(function() {
        this.field('title', { boost: 10 });
        this.field('content');
        this.field('description', { boost: 5 });
        this.field('tags', { boost: 50 });
        this.ref('id');
        this.tokenizer(camelCaseTokenizer);

        this.pipeline.remove(lunr.stopWordFilter);
        this.pipeline.remove(lunr.stemmer);
    });
    function a(e) { 
        idx.add(e); 
    }

    a({
        id:0,
        title:"AppVeyorApi",
        content:"AppVeyorApi",
        description:'',
        tags:''
    });

    a({
        id:1,
        title:"ProjectHistory",
        content:"ProjectHistory",
        description:'',
        tags:''
    });

    a({
        id:2,
        title:"ProjectDeployments",
        content:"ProjectDeployments",
        description:'',
        tags:''
    });

    a({
        id:3,
        title:"JwtAuthHeader",
        content:"JwtAuthHeader",
        description:'',
        tags:''
    });

    a({
        id:4,
        title:"Job",
        content:"Job",
        description:'',
        tags:''
    });

    a({
        id:5,
        title:"ProjectNuGetFeed",
        content:"ProjectNuGetFeed",
        description:'',
        tags:''
    });

    a({
        id:6,
        title:"ApiResponse",
        content:"ApiResponse",
        description:'',
        tags:''
    });

    a({
        id:7,
        title:"ProjectMessage",
        content:"ProjectMessage",
        description:'',
        tags:''
    });

    a({
        id:8,
        title:"Build StatusEnum",
        content:"Build StatusEnum",
        description:'',
        tags:''
    });

    a({
        id:9,
        title:"DeploymentClient",
        content:"DeploymentClient",
        description:'',
        tags:''
    });

    a({
        id:10,
        title:"ProjectSecurityDescriptorRoleAce",
        content:"ProjectSecurityDescriptorRoleAce",
        description:'',
        tags:''
    });

    a({
        id:11,
        title:"ProjectJob OsTypeEnum",
        content:"ProjectJob OsTypeEnum",
        description:'',
        tags:''
    });

    a({
        id:12,
        title:"ProjectJob",
        content:"ProjectJob",
        description:'',
        tags:''
    });

    a({
        id:13,
        title:"ProjectJob StatusEnum",
        content:"ProjectJob StatusEnum",
        description:'',
        tags:''
    });

    a({
        id:14,
        title:"RepositoryScmEnum",
        content:"RepositoryScmEnum",
        description:'',
        tags:''
    });

    a({
        id:15,
        title:"BuildClient",
        content:"BuildClient",
        description:'',
        tags:''
    });

    a({
        id:16,
        title:"SecurityDescriptor",
        content:"SecurityDescriptor",
        description:'',
        tags:''
    });

    a({
        id:17,
        title:"ProjectSecurityDescriptorAccessRight NameEnum",
        content:"ProjectSecurityDescriptorAccessRight NameEnum",
        description:'',
        tags:''
    });

    a({
        id:18,
        title:"EnvironmentProvider",
        content:"EnvironmentProvider",
        description:'',
        tags:''
    });

    a({
        id:19,
        title:"Build",
        content:"Build",
        description:'',
        tags:''
    });

    a({
        id:20,
        title:"RepositoryTypeEnum",
        content:"RepositoryTypeEnum",
        description:'',
        tags:''
    });

    a({
        id:21,
        title:"JobStatus",
        content:"JobStatus",
        description:'',
        tags:''
    });

    a({
        id:22,
        title:"StartBuildInfo",
        content:"StartBuildInfo",
        description:'',
        tags:''
    });

    a({
        id:23,
        title:"Environment",
        content:"Environment",
        description:'',
        tags:''
    });

    a({
        id:24,
        title:"Deployment",
        content:"Deployment",
        description:'',
        tags:''
    });

    a({
        id:25,
        title:"AppVeyorApiOptions",
        content:"AppVeyorApiOptions",
        description:'',
        tags:''
    });

    a({
        id:26,
        title:"AppVeyorClientException",
        content:"AppVeyorClientException",
        description:'',
        tags:''
    });

    a({
        id:27,
        title:"BaseClient",
        content:"BaseClient",
        description:'',
        tags:''
    });

    a({
        id:28,
        title:"ProjectMessage CategoryEnum",
        content:"ProjectMessage CategoryEnum",
        description:'',
        tags:''
    });

    a({
        id:29,
        title:"ProjectBuild",
        content:"ProjectBuild",
        description:'',
        tags:''
    });

    a({
        id:30,
        title:"ProjectSecurityDescriptorAccessRightDefinition",
        content:"ProjectSecurityDescriptorAccessRightDefinition",
        description:'',
        tags:''
    });

    a({
        id:31,
        title:"ProjectSecurityDescriptorAccessRight",
        content:"ProjectSecurityDescriptorAccessRight",
        description:'',
        tags:''
    });

    a({
        id:32,
        title:"ApiResponse",
        content:"ApiResponse",
        description:'',
        tags:''
    });

    a({
        id:33,
        title:"ProjectSecurityDescriptorAccessRightDefinition NameEnum",
        content:"ProjectSecurityDescriptorAccessRightDefinition NameEnum",
        description:'',
        tags:''
    });

    a({
        id:34,
        title:"DeploymentStatus",
        content:"DeploymentStatus",
        description:'',
        tags:''
    });

    a({
        id:35,
        title:"ProjectSecurityDescriptor",
        content:"ProjectSecurityDescriptor",
        description:'',
        tags:''
    });

    a({
        id:36,
        title:"Project",
        content:"Project",
        description:'',
        tags:''
    });

    a({
        id:37,
        title:"ProjectClient",
        content:"ProjectClient",
        description:'',
        tags:''
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient/AppVeyorApi',
        title:"AppVeyorApi",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectHistory',
        title:"ProjectHistory",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectDeployments',
        title:"ProjectDeployments",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Clients/JwtAuthHeader',
        title:"JwtAuthHeader",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/Job',
        title:"Job",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectNuGetFeed',
        title:"ProjectNuGetFeed",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ApiResponse',
        title:"ApiResponse",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectMessage',
        title:"ProjectMessage",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/StatusEnum',
        title:"Build.StatusEnum",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Clients/DeploymentClient',
        title:"DeploymentClient",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectSecurityDescriptorRoleAce',
        title:"ProjectSecurityDescriptorRoleAce",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/OsTypeEnum',
        title:"ProjectJob.OsTypeEnum",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectJob',
        title:"ProjectJob",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/StatusEnum',
        title:"ProjectJob.StatusEnum",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/RepositoryScmEnum',
        title:"RepositoryScmEnum",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Clients/BuildClient',
        title:"BuildClient",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/SecurityDescriptor',
        title:"SecurityDescriptor",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/NameEnum',
        title:"ProjectSecurityDescriptorAccessRight.NameEnum",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/EnvironmentProvider',
        title:"EnvironmentProvider",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/Build',
        title:"Build",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/RepositoryTypeEnum',
        title:"RepositoryTypeEnum",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/JobStatus',
        title:"JobStatus",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/StartBuildInfo',
        title:"StartBuildInfo",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/Environment',
        title:"Environment",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/Deployment',
        title:"Deployment",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient/AppVeyorApiOptions',
        title:"AppVeyorApiOptions",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient/AppVeyorClientException',
        title:"AppVeyorClientException",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Clients/BaseClient',
        title:"BaseClient",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/CategoryEnum',
        title:"ProjectMessage.CategoryEnum",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectBuild',
        title:"ProjectBuild",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectSecurityDescriptorAccessRightDefinition',
        title:"ProjectSecurityDescriptorAccessRightDefinition",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectSecurityDescriptorAccessRight',
        title:"ProjectSecurityDescriptorAccessRight",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ApiResponse_1',
        title:"ApiResponse<T>",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/NameEnum',
        title:"ProjectSecurityDescriptorAccessRightDefinition.NameEnum",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/DeploymentStatus',
        title:"DeploymentStatus",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/ProjectSecurityDescriptor',
        title:"ProjectSecurityDescriptor",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Model/Project',
        title:"Project",
        description:""
    });

    y({
        url:'/appveyor-api-client/appveyor-api-client/api/AppVeyorClient.Clients/ProjectClient',
        title:"ProjectClient",
        description:""
    });

    return {
        search: function(q) {
            return idx.search(q).map(function(i) {
                return idMap[i.ref];
            });
        }
    };
}();
