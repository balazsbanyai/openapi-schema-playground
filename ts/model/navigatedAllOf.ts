/**
 * Events
 * Polymorphism example
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { RequestFile } from '../api';

export class NavigatedAllOf {
    'newPath'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "newPath",
            "baseName": "newPath",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return NavigatedAllOf.attributeTypeMap;
    }
}

