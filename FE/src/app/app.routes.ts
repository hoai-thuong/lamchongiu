import { Routes } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { DonationListComponent } from './donation-list/donation-list.component';
import { SideBarComponent } from './admin-management/side-bar/side-bar.component';
import { UsersComponent } from './admin-management/users/users.component';
import { CampaignsComponent } from './admin-management/campaigns/campaigns.component';
import { StatisticComponent } from './admin-management/statistic/statistic.component';
import { PaymentComponent } from './payment/payment.component';
import { PartnersComponent } from './partners/partners.component';
import { HomepageComponent } from './homepage/homepage.component';
import { PaymentsuccessComponent } from './paymentsuccess/paymentsuccess.component';

export const routes: Routes = [
  {
    path: '', component: HomepageComponent
  },
  {
    path: 'donation-list', component: DonationListComponent
  },
  //{
  //  path: 'admin', component: SideBarComponent, children: [
  //    { path: 'users', component: UsersComponent },
  //    { path: 'campaigns', component: CampaignsComponent },
  //    { path: 'statistic', component: StatisticComponent },
  //  ]
  //},
  {
    path: 'payment/:campaignCode', component: PaymentComponent

  },
  {
    path: 'partners', component: PartnersComponent
  },

  { path: 'paymentsuccess', component: PaymentsuccessComponent },

/*  { path: 'execute-payment', component: PaymentComponent }*/

]
