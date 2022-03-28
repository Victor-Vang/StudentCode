import Vue from 'vue'
import { component } from 'vue/types/umd';
import App from './App.vue'
import TodoList from './components/TodoList';

Vue.config.productionTip = false

new Vue({
  render: h => h(App),
}).$mount('#app')

components: {
  TodoList
}