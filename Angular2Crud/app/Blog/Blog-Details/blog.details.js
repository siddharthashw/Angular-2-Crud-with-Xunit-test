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
var blog_service_1 = require('../blog.service');
var blog_1 = require('../blog');
var router_1 = require('@angular/router');
var common_1 = require("@angular/common");
var BlogDetails = (function () {
    function BlogDetails(http, route, location) {
        this.http = http;
        this.route = route;
        this.location = location;
        this.blogs = new blog_1.Blog;
    }
    BlogDetails.prototype.ngOnInit = function () {
        this.getBlog();
    };
    BlogDetails.prototype.getBlog = function () {
        var _this = this;
        this.id = this.route.params.subscribe(function (params) {
            var id = _this.route.snapshot.params['id'];
            _this.http.getById(id).subscribe(function (result) {
                _this.blogs = result;
            });
        });
    };
    BlogDetails.prototype.goBack = function () {
        this.location.back();
    };
    BlogDetails = __decorate([
        core_1.Component({
            selector: 'my-app',
            templateUrl: './app/Blog/Blog-Details/blog-details.html',
        }), 
        __metadata('design:paramtypes', [blog_service_1.BlogService, router_1.ActivatedRoute, common_1.Location])
    ], BlogDetails);
    return BlogDetails;
}());
exports.BlogDetails = BlogDetails;
//# sourceMappingURL=blog.details.js.map