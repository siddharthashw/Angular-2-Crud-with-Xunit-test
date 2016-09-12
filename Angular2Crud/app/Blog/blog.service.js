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
var http_service_1 = require('../http.service');
require('rxjs/add/operator/map');
require('rxjs/add/operator/catch');
require('rxjs/Rx');
var BlogService = (function () {
    function BlogService(http) {
        this.http = http;
    }
    BlogService.prototype.getAll = function () {
        return this.http.get("api/blog");
    };
    BlogService.prototype.getById = function (id) {
        return this.http.get("api/blog/" + id);
    };
    BlogService.prototype.AddBlog = function (blog) {
        return this.http.post("api/blog/add", blog);
    };
    BlogService.prototype.UpdateBlog = function (blog) {
        return this.http.put("api/blog/update", blog);
    };
    BlogService.prototype.DeleteBlog = function (id) {
        return this.http.delete("api/blog/delete/" + id);
    };
    BlogService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [http_service_1.HttpService])
    ], BlogService);
    return BlogService;
}());
exports.BlogService = BlogService;
//# sourceMappingURL=blog.service.js.map