import { Component, OnInit } from '@angular/core';
import { BlogService } from '../blog.service';
import { Blog }  from '../blog';
import { Router, ROUTER_DIRECTIVES, ActivatedRoute }from '@angular/router';
import {Location} from "@angular/common";


@Component({
    selector: 'my-app',
    templateUrl: './app/Blog/Blog-Details/blog-details.html',
})
export class BlogDetails implements OnInit {
    blogs = new Blog;
    id: any;
    constructor(private http: BlogService, private route: ActivatedRoute, private location: Location) { }
    ngOnInit() {
        this.getBlog();
    }

    getBlog() {
        this.id = this.route.params.subscribe(params => {
            let id = this.route.snapshot.params['id'];
            this.http.getById(id).subscribe((result: any) => {
                this.blogs = result;
            })
        })
    }
    goBack() {
        this.location.back();
    }
}
