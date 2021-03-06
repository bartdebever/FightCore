import { TabComponentInterface } from './tab-component.interface';
import { TabItem } from './tab-item';
import { Component, OnInit, Input, ViewChild, ComponentFactoryResolver } from '@angular/core';
import { TabDirective } from './tab.directive';

// TODO: Rewrite this entire folder to be less about tabs and more just about a modular section

@Component({
  selector: 'tab-contents',
  template: '<ng-template tab-host></ng-template>',
})
export class TabContentsComponent implements OnInit {
  @Input('tab') tab: TabItem;
  @ViewChild(TabDirective) tabHost: TabDirective;

  constructor(private componentFactoryResolver: ComponentFactoryResolver) { }

  ngOnInit() {
    let componentFactory = this.componentFactoryResolver.resolveComponentFactory(this.tab.component);

    let viewContainerRef = this.tabHost.viewContainerRef;
    viewContainerRef.clear(); // Not sure if this line is necessary, ripping off of loading/reloading function

    let componentRef = viewContainerRef.createComponent(componentFactory);
    (<TabComponentInterface>componentRef.instance).data = this.tab.data;
  }

}
