import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import { Cabin } from '../../cabin/cabin';
import * as $ from 'jquery';

@Component
export default class HomeComponent extends Vue {
    cabins: Cabin[] = [];
    mounted() {
        fetch('api/cabin')
            .then(response => response.json() as Promise<Cabin[]>)
            .then(data => {
                this.cabins = data;
            });
    }
}