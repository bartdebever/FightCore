import { PostService } from './../../services/post.service';
import { Component, OnInit, ViewChild, TemplateRef } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { Post } from '../../models/Post';
import { Location } from '@angular/common';
import { PostPopupComponent } from '../../components/post-popup/post-popup.component';

@Component({
  selector: 'app-library',
  templateUrl: './library.component.html',
  styleUrls: ['./library.component.css']
})
export class LibraryComponent implements OnInit {
  posts: Post[];
  displayPost: Post;
  @ViewChild('postContent') postContent: TemplateRef<any>;
  @ViewChild('postPopup') postPopup: PostPopupComponent;

  constructor(private titleService: Title, 
    private router: Router, 
    private postService: PostService) { }

  ngOnInit() {
    this.titleService.setTitle("Library");
    this.posts = this.postService.getPosts();
  }
  
  /**
   * Navigates to the add post page
   */
  goToAddPost() {
    this.router.navigate(['/library/add']);
  }

  /**
   * Wrapper for PostService.getPostUrl (don't believe can call static functions from template)
   * TODO: Can we remove this now? Doesn't seem like we need it anymore
   * @param post Post to create url for
   * @returns post url for routerLink 
   */
  getPostUrl(post: Post):string {
    return PostService.getPostUrl(post);
  }

  /**
   * Opens a post view page in a modal popup
   * @param post Represents post whose page to open, assumed to be valid
   */
  open(post: Post) {
    this.postPopup.openPopup(post);
  }

}
