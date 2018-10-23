import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import { Cabin } from '../../cabin/cabin';
import * as $ from 'jquery';

@Component
export default class CreateComponent extends Vue {
    cabin: Cabin = new Cabin();
    //data: Cabin;
    //address: string;
    //name: string;

    createCabin() {
        $.ajax({
            type: "POST",
            url: "api/cabin",
            contentType: "application/json",
            dataType: "json",
            data: JSON.stringify (this.cabin),
        });
    }
}
