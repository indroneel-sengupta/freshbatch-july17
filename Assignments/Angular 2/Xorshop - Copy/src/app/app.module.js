"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var app_component_1 = require("./app.component");
var homeComponent_component_1 = require("./components/homeComponent/homeComponent.component");
var loginHome_component_1 = require("./components/loginHome/loginHome.component");
var postAdd_component_1 = require("./components/postAdd/postAdd.component");
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [platform_browser_1.BrowserModule, forms_1.FormsModule, http_1.HttpModule, router_1.RouterModule.forRoot([
                { path: '', component: homeComponent_component_1.HomeComponent },
                { path: 'loginHome/:authToken/:userName', component: loginHome_component_1.LoginHome },
                { path: 'postAdd/:authToken/:userName', component: postAdd_component_1.PostAdd }
            ])
        ],
        declarations: [app_component_1.AppComponent, homeComponent_component_1.HomeComponent, loginHome_component_1.LoginHome, postAdd_component_1.PostAdd],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map