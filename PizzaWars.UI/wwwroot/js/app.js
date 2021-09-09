var app = new Vue({
    el: '#app',
    data: {
        pizzas: [],
        homePizza: [],
        counter: 0,
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
        },
        incrCounter() {
            this.counter++
        },
    }
})