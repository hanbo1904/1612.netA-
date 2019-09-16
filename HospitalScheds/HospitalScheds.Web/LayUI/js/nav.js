var navs = [];
$.ajax({
    type: "get",
    url: "User/GetLeftMenus",
    async: false,
    success: function (result) {
        navs = result;
    }
})

//var navs = [{
//	"title" : "后台首页",
//	"icon" : "icon-computer",
//	"href" : "page/main.html",
//	"spread" : false
//},{
//	"title" : "文章列表",
//	"icon" : "icon-text",
//	"href" : "page/news/newsList.html",
//	"spread" : false
//},{
//	"title" : "中华儿女多奇志",
//	"icon" : "icon-text",
//	"href" : "page/links/linksList.html",
//	"spread" : false
//},{
//	"title" : "404页面",
//	"icon" : "&#xe61c;",
//	"href" : "page/404.html",
//	"spread" : false
//},{
//	"title" : "系统基本参数",
//	"icon" : "&#xe631;",
//	"href" : "page/systemParameter/systemParameter.html",
//	"spread" : false
//},{
//	"title" : "二级菜单演示",
//	"icon" : "&#xe61c;",
//	"href" : "",
//	"spread" : false,
//	"children" : [
//		{
//			"title" : "二级菜单1",
//			"icon" : "&#xe631;",
//			"href" : "page/systemParameter/systemParameter.html",
//			"spread" : false
//		},
//		{
//			"title" : "二级菜单2",
//			"icon" : "&#xe631;",
//			"href" : "page/systemParameter/systemParameter.html",
//			"spread" : false
//		}
//	]
//}]