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
var core_1 = require("@angular/core");
var registrationService_service_1 = require("../../services/registrationService/registrationService.service");
var loginService_service_1 = require("../../services/loginService/loginService.service");
var router_1 = require("@angular/router");
var categoriesService_service_1 = require("../../services/categoriesServices/categoriesService.service");
var HomeComponent = (function () {
    function HomeComponent(regService, logService, router, categoriesService) {
        var _this = this;
        this.regService = regService;
        this.logService = logService;
        this.router = router;
        this.categoriesService = categoriesService;
        this.categories = [];
        categoriesService.getAllCategories().subscribe(function (response) {
            response.data.itemList.forEach(function (add) {
                _this.categories.push(add.name);
                console.log(_this.categories);
            });
        });
    }
    HomeComponent.prototype.onClickRegister = function (fName, lName, uName, pwd, emailID, phn) {
        var _this = this;
        this.storeReg =
            { firstName: fName,
                lastName: lName,
                userName: uName,
                password: pwd,
                email: emailID,
                phone: phn };
        this.regService.sendRegDetail(this.storeReg).subscribe(function (data) {
            _this.successfullReg = data;
            console.log('Received products: ', _this.successfullReg);
        });
    };
    HomeComponent.prototype.onClickLogin = function (uName, pwd) {
        var _this = this;
        this.storeLog =
            { userName: uName,
                password: pwd };
        this.logService.sendLogDetail(this.storeLog).subscribe(function (data) {
            _this.successfullLog = data;
            console.log('Login: ', _this.successfullLog);
            _this.authToken = _this.successfullLog.data['auth-token'];
            if (_this.authToken == null) {
                _this.tempSuccess = false;
                console.log(" tempSuccessFalse ", _this.tempSuccess);
            }
            else {
                _this.tempSuccess = true;
                _this.router.navigate(['/loginHome', _this.authToken, _this.storeLog.userName]);
            }
        });
    };
    return HomeComponent;
}());
HomeComponent = __decorate([
    core_1.Component({
        selector: 'homeComponent',
        templateUrl: "./homeComponent.html",
    }),
    __metadata("design:paramtypes", [registrationService_service_1.RegistrationService, loginService_service_1.LoginService, router_1.Router, categoriesService_service_1.CategoriesService])
], HomeComponent);
exports.HomeComponent = HomeComponent;
//# sourceMappingURL=homeComponent.component.js.map