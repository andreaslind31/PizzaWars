'use strict';

//a component’s data option must be a function,
//so that each instance can maintain an independent copy of the returned data object:
Vue.component('add-sauces', {
    data: function () {
        return {
            count: 0
        }
    },
    template: '<button class="btn btn-light" v-on:click="count++">Click me to add sauce: {{ count }}</button>'
})
Vue.component('add-toppings', {
    props: ['topping'],
    data: function (topping) {
        return this.selected = topping;
    },
    template: `
    <div class="add-toppings">
      <p>{{ topping.text }}</p>
      <div v-html="topping.content"></div>
    </div>
  `
})
Vue.component('topping-checkbox', {
    model: {
        prop: 'checked',
        event: 'change'
    },
    props: {
        checked: Boolean
    },
    template: `
            <input
                type="checkbox"
                v-bind:checked="checked"
                v-on:change="$emit('change', $event.target.checked)"
                >
    `
})

var app = new Vue({
    el: '#app',
    data: {
        message: 'You loaded this page on ' + new Date().toLocaleString(),
        pizzas: [],
        homePizza: [],
        counter: 0,
        winner: false,
        selected: '',
        additionalToppings: [
            { text: "Moooore Tomatoes" },
            { text: "Cheeseuzz" },
            { text: "Ham-string me" },
            { text: "Shruuuuums" },
            { text: "Shrimpsus" },
            { text: "Pineapple-me" },
            { text: "Beer?" },
        ]
    },
    mounted() {
        this.getData();
        this.getDataHome();
    },
    methods: {
        getData() {
            axios.get('/Pizza/Pizzas').then(res => {
                this.pizzas = res.data;
                console.log(res.data);
            }).catch(err => {
                console.log(err)
            });
            this.counter = 0;
            this.winner = false;
        },
        getDataHome() {
            axios.get('/Home/HomePizzaImg').then(res => {
                this.homePizza = res.data;
                console.log(res.data);
            }).catch(err => {
                console.log(err)
            });
        },
        deletePizza(name) {
            this.pizzas = this.pizzas.filter(function (obj) {
                return obj.name !== name;
            });
            this.counter++;
        },
        winnerPizza(name) {
            this.pizzas = this.pizzas.filter(function (obj) {
                obj.hypeLevel++;
                return obj.name === name;
            });
            console.log(this.pizzas.name);
            if (this.counter < 10) {
                this.counter++;
            }
            this.winner = true;
        },
    }
})