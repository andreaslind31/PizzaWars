var app = new Vue({
    el: '#app',
    data: {
        pizzas: [],
        message: 'Här blir det pizzooor!',
        showMessage: true,
        counter: 0,
    },
    mounted() {
        this.getData();
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
        deletePizza(name) {
            this.pizzas = this.pizzas.filter(function (obj) {
                return obj.name !== name;
            });
        },
        incrCounter() {
            this.counter++
        },
        winner() {

        }
    }
})