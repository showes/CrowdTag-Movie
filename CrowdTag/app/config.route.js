﻿(function () {
    'use strict';

    var app = angular.module('app');

    // Collect the routes
    app.constant('routes', getRoutes());
    
    // Configure the routes and route resolvers
    app.config(['$routeProvider', 'routes', routeConfigurator]);
    function routeConfigurator($routeProvider, routes) {
        routes.forEach(function (r) {
            setRoute(r.url, r.config);
            //$routeProvider.when(r.url, r.config);
        });
        $routeProvider.otherwise({ redirectTo: '/' });

        function setRoute(url, definition) {
            // Sets reslovers for all of the routes by 
            // extending any existing resolvers or creating a new one
            definition.resolve = angular.extend(definition.resolve || {
                prime: prime
            });
            $routeProvider.when(url, definition);
            return $routeProvider;
        }
    }

    prime.$inject = ['datacontext'];
    function prime(datacontext) {
        return datacontext.prime();
    }

    // Define the routes 
    function getRoutes() {
        return [
            {
                url: '/',
                config: {
                    templateUrl: 'app/dashboard/dashboard.html',
                    title: 'dashboard',
                    settings: {
                        nav: 1,
                        content: '<i class="fa fa-dashboard"></i> Dashboard'
                    }
                }
            }, {
                url: '/drinks',
                config: {
                    title: 'drinks',
                    templateUrl: 'app/drinks/drinks.html',
                    settings: {
                        nav: 2,
                        content: '<i class="fa fa-glass"></i> Drinks'
                    }
                }
            }, {
                url: '/drinks/:id',
                config: {
                    title: 'drink',
                    templateUrl: 'app/drinks/drinkDetail.html',
                    settings: {}
                }
            }, {
                url: '/ingredients',
                config: {
                    title: 'ingredients',
                    templateUrl: 'app/ingredients/ingredients.html',
                    settings: {
                        nav: 3,
                        content: '<i class="fa fa-lemon-o"></i> Ingredients'
                    }
                }
            }, {
                url: '/ingredients/:id',
                config: {
                    title: 'ingredient',
                    templateUrl: 'app/ingredients/ingredientDetail.html',
                    settings: {}
                }
            }, {
                url: '/admin',
                config: {
                    title: 'admin',
                    templateUrl: 'app/admin/admin.html',
                    settings: {
                        nav: 4,
                        content: '<i class="fa fa-lock"></i> Admin'
                    }
                }
            }
        ];
    }
})();