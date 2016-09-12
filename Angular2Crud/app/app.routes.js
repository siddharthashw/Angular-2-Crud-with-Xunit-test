"use strict";
var router_1 = require('@angular/router');
var blog_list_1 = require('./blog/blog-list/blog.list');
var blog_details_1 = require('./blog/blog-details/blog.details');
var blog_add_1 = require('./blog/blog-add/blog.add');
var blog_delete_1 = require('./blog/blog-delete/blog.delete');
var blog_edit_1 = require('./blog/blog-edit/blog.edit');
var appRoutes = [
    { path: '', component: blog_list_1.BlogList },
    { path: 'detail/:id', component: blog_details_1.BlogDetails },
    { path: 'edit/:id', component: blog_edit_1.BlogEdit },
    { path: 'delete/:id', component: blog_delete_1.BlogDelete },
    { path: 'add', component: blog_add_1.BlogAdd }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routes.js.map