"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var platform_browser_1 = require('@angular/platform-browser');
var app_component_1 = require('./app.component');
var blog_service_1 = require('./blog/blog.service');
var blog_list_1 = require('./blog/blog-list/blog.list');
var app_routes_1 = require('./app.routes');
var http_1 = require('@angular/http');
var forms_1 = require('@angular/forms');
var blog_details_1 = require('./blog/blog-details/blog.details');
var http_service_1 = require('./http.service');
var blog_add_1 = require('./blog/blog-add/blog.add');
var blog_delete_1 = require('./blog/blog-delete/blog.delete');
var blog_edit_1 = require('./blog/blog-edit/blog.edit');
var AppModule = (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            imports: [platform_browser_1.BrowserModule, app_routes_1.routing, forms_1.FormsModule, http_1.HttpModule],
            declarations: [app_component_1.AppComponent, blog_list_1.BlogList, blog_details_1.BlogDetails, blog_add_1.BlogAdd, blog_delete_1.BlogDelete, blog_edit_1.BlogEdit],
            bootstrap: [app_component_1.AppComponent],
            providers: [http_service_1.HttpService, blog_service_1.BlogService]
        }), 
        __metadata('design:paramtypes', [])
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map