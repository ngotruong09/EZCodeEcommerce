import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'ProductService',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44356',
    redirectUri: baseUrl,
    clientId: 'ProductService_App',
    responseType: 'code',
    scope: 'offline_access ProductService',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44356',
      rootNamespace: 'EZCode.ProductService',
    },
    ProductService: {
      url: 'https://localhost:44385',
      rootNamespace: 'EZCode.ProductService',
    },
  },
} as Environment;
