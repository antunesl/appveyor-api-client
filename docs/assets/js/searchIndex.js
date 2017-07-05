
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
        title:"Job",
        content:"Job",
        description:'',
        tags:''
    });

    a({
        id:1,
        title:"ProjectSecurityDescriptorAccessRightDefinition NameEnum",
        content:"ProjectSecurityDescriptorAccessRightDefinition NameEnum",
        description:'',
        tags:''
    });

    a({
        id:2,
        title:"ProjectHistory",
        content:"ProjectHistory",
        description:'',
        tags:''
    });

    a({
        id:3,
        title:"ProjectMessage CategoryEnum",
        content:"ProjectMessage CategoryEnum",
        description:'',
        tags:''
    });

    a({
        id:4,
        title:"ProjectSecurityDescriptorAccessRight NameEnum",
        content:"ProjectSecurityDescriptorAccessRight NameEnum",
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
        title:"ProjectSecurityDescriptorRoleAce",
        content:"ProjectSecurityDescriptorRoleAce",
        description:'',
        tags:''
    });

    a({
        id:7,
        title:"AppVeyorApiOptions",
        content:"AppVeyorApiOptions",
        description:'',
        tags:''
    });

    a({
        id:8,
        title:"ProjectSecurityDescriptor",
        content:"ProjectSecurityDescriptor",
        description:'',
        tags:''
    });

    a({
        id:9,
        title:"EnvironmentProvider",
        content:"EnvironmentProvider",
        description:'',
        tags:''
    });

    a({
        id:10,
        title:"RepositoryTypeEnum",
        content:"RepositoryTypeEnum",
        description:'',
        tags:''
    });

    a({
        id:11,
        title:"BuildClient",
        content:"BuildClient",
        description:'',
        tags:''
    });

    a({
        id:12,
        title:"DeploymentClient",
        content:"DeploymentClient",
        description:'',
        tags:''
    });

    a({
        id:13,
        title:"ProjectSecurityDescriptorAccessRightDefinition",
        content:"ProjectSecurityDescriptorAccessRightDefinition",
        description:'',
        tags:''
    });

    a({
        id:14,
        title:"ProjectBuild",
        content:"ProjectBuild",
        description:'',
        tags:''
    });

    a({
        id:15,
        title:"Deployment",
        content:"Deployment",
        description:'',
        tags:''
    });

    a({
        id:16,
        title:"DeploymentStatus",
        content:"DeploymentStatus",
        description:'',
        tags:''
    });

    a({
        id:17,
        title:"ApiResponse",
        content:"ApiResponse",
        description:'',
        tags:''
    });

    a({
        id:18,
        title:"StartBuildInfo",
        content:"StartBuildInfo",
        description:'',
        tags:''
    });

    a({
        id:19,
        title:"SecurityDescriptor",
        content:"SecurityDescriptor",
        description:'',
        tags:''
    });

    a({
        id:20,
        title:"ProjectJob StatusEnum",
        content:"ProjectJob StatusEnum",
        description:'',
        tags:''
    });

    a({
        id:21,
        title:"ProjectJob",
        content:"ProjectJob",
        description:'',
        tags:''
    });

    a({
        id:22,
        title:"ProjectMessage",
        content:"ProjectMessage",
        description:'',
        tags:''
    });

    a({
        id:23,
        title:"ProjectDeployments",
        content:"ProjectDeployments",
        description:'',
        tags:''
    });

    a({
        id:24,
        title:"BaseClient",
        content:"BaseClient",
        description:'',
        tags:''
    });

    a({
        id:25,
        title:"ProjectJob OsTypeEnum",
        content:"ProjectJob OsTypeEnum",
        description:'',
        tags:''
    });

    a({
        id:26,
        title:"ApiResponse",
        content:"ApiResponse",
        description:'',
        tags:''
    });

    a({
        id:27,
        title:"JwtAuthHeader",
        content:"JwtAuthHeader",
        description:'',
        tags:''
    });

    a({
        id:28,
        title:"Environment",
        content:"Environment",
        description:'',
        tags:''
    });

    a({
        id:29,
        title:"AppVeyorClientException",
        content:"AppVeyorClientException",
        description:'',
        tags:''
    });

    a({
        id:30,
        title:"Build",
        content:"Build",
        description:'',
        tags:''
    });

    a({
        id:31,
        title:"RepositoryScmEnum",
        content:"RepositoryScmEnum",
        description:'',
        tags:''
    });

    a({
        id:32,
        title:"Build StatusEnum",
        content:"Build StatusEnum",
        description:'',
        tags:''
    });

    a({
        id:33,
        title:"ProjectClient",
        content:"ProjectClient",
        description:'',
        tags:''
    });

    a({
        id:34,
        title:"ProjectSecurityDescriptorAccessRight",
        content:"ProjectSecurityDescriptorAccessRight",
        description:'',
        tags:''
    });

    a({
        id:35,
        title:"JobStatus",
        content:"JobStatus",
        description:'',
        tags:''
    });

    a({
        id:36,
        title:"AppVeyorApi",
        content:"AppVeyorApi",
        description:'',
        tags:''
    });

    a({
        id:37,
        title:"Project",
        content:"Project",
        description:'',
        tags:''
    });

    y({
        url:'/api/AppVeyorClient.Model/Job',
        title:"Job",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/NameEnum',
        title:"ProjectSecurityDescriptorAccessRightDefinition.NameEnum",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectHistory',
        title:"ProjectHistory",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/CategoryEnum',
        title:"ProjectMessage.CategoryEnum",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/NameEnum',
        title:"ProjectSecurityDescriptorAccessRight.NameEnum",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectNuGetFeed',
        title:"ProjectNuGetFeed",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectSecurityDescriptorRoleAce',
        title:"ProjectSecurityDescriptorRoleAce",
        description:""
    });

    y({
        url:'/api/AppVeyorClient/AppVeyorApiOptions',
        title:"AppVeyorApiOptions",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectSecurityDescriptor',
        title:"ProjectSecurityDescriptor",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/EnvironmentProvider',
        title:"EnvironmentProvider",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/RepositoryTypeEnum',
        title:"RepositoryTypeEnum",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Clients/BuildClient',
        title:"BuildClient",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Clients/DeploymentClient',
        title:"DeploymentClient",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectSecurityDescriptorAccessRightDefinition',
        title:"ProjectSecurityDescriptorAccessRightDefinition",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectBuild',
        title:"ProjectBuild",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/Deployment',
        title:"Deployment",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/DeploymentStatus',
        title:"DeploymentStatus",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ApiResponse',
        title:"ApiResponse",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/StartBuildInfo',
        title:"StartBuildInfo",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/SecurityDescriptor',
        title:"SecurityDescriptor",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/StatusEnum',
        title:"ProjectJob.StatusEnum",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectJob',
        title:"ProjectJob",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectMessage',
        title:"ProjectMessage",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectDeployments',
        title:"ProjectDeployments",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Clients/BaseClient',
        title:"BaseClient",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/OsTypeEnum',
        title:"ProjectJob.OsTypeEnum",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ApiResponse_1',
        title:"ApiResponse<T>",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Clients/JwtAuthHeader',
        title:"JwtAuthHeader",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/Environment',
        title:"Environment",
        description:""
    });

    y({
        url:'/api/AppVeyorClient/AppVeyorClientException',
        title:"AppVeyorClientException",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/Build',
        title:"Build",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/RepositoryScmEnum',
        title:"RepositoryScmEnum",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/StatusEnum',
        title:"Build.StatusEnum",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Clients/ProjectClient',
        title:"ProjectClient",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/ProjectSecurityDescriptorAccessRight',
        title:"ProjectSecurityDescriptorAccessRight",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/JobStatus',
        title:"JobStatus",
        description:""
    });

    y({
        url:'/api/AppVeyorClient/AppVeyorApi',
        title:"AppVeyorApi",
        description:""
    });

    y({
        url:'/api/AppVeyorClient.Model/Project',
        title:"Project",
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
