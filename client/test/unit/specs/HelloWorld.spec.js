import Vue from 'vue';
import HelloWorld from '@/components/HelloWorld';

describe('HelloWorld.vue', () => {
  it('should render correct contents', () => {
    const Constructor = Vue.extend(HelloWorld);
    const vm = new Constructor().$mount();
    vm.$el.querySelector('button').click();
    Vue.nextTick()
      .then(() => {
        expect(vm.$el.querySelector('.message').textContent)
          .toEqual('Hello World!');
      });
  });
});
