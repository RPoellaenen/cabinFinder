import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import { Cabin } from '../../cabin/cabin';

@Component
export default class CreateComponent extends Vue {
    data: Cabin;

    createCabin() {
        $.ajax({
            type: "POST",
            url: "api/cabin",
            contentType: "application/json",
            dataType: "json",
        });
    }
}
