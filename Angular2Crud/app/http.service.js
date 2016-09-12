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
var http_1 = require("@angular/http");
var core_1 = require("@angular/core");
var Observable_1 = require('rxjs/Observable');
require('rxjs/add/operator/map');
require('rxjs/add/operator/catch');
require('rxjs/Rx');
var HttpService = (function () {
    function HttpService(http) {
        this.http = http;
    }
    HttpService.prototype.get = function (url) {
        return this.intercept(this.http.get(url).map(function (res) { return res.json(); }));
    };
    HttpService.prototype.post = function (url, body) {
        var jsonBody = JSON.stringify(body);
        var headers = new http_1.Headers({ 'Content-Type': 'application/json; charset=utf-8' });
        var options = new http_1.RequestOptions({ headers: headers });
        return this.intercept(this.http.post(url, jsonBody, options).map(function (res) { return res.json(); }));
    };
    HttpService.prototype.put = function (url, body) {
        var jsonBody = JSON.stringify(body);
        var headers = new http_1.Headers({ 'Content-Type': 'application/json; charset=utf-8' });
        var options = new http_1.RequestOptions({ headers: headers });
        return this.intercept(this.http.put(url, jsonBody, options).map(function (res) { return res.json(); }));
    };
    HttpService.prototype.delete = function (url) {
        return this.intercept(this.http.delete(url).map(function (res) { return res.json(); }));
    };
    HttpService.prototype.intercept = function (observable) {
        return observable.catch(function (err, source) {
            if (err.status === 401) {
                location.href = "/Login";
            }
            else if (err.status === 500) {
                return Observable_1.Observable.throw(err);
            }
            else {
                return Observable_1.Observable.throw(err);
            }
        });
    };
    HttpService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [http_1.Http])
    ], HttpService);
    return HttpService;
}());
exports.HttpService = HttpService;
//# sourceMappingURL=http.service.js.map