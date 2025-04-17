﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000077 RID: 119
	public static class GraphicsUtils : Object
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x0008A3F8 File Offset: 0x000885F8
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsUtils()
		{
			Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "GraphicsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr);
			GraphicsUtils.NativeFieldInfoPtr_s_WhiteTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, "s_WhiteTexture");
			GraphicsUtils.NativeFieldInfoPtr_s_Quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, "s_Quad");
			GraphicsUtils.NativeMethodInfoPtr_get_isLinearColorSpace_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664189);
			GraphicsUtils.NativeMethodInfoPtr_get_supportsDX11_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664190);
			GraphicsUtils.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664191);
			GraphicsUtils.NativeMethodInfoPtr_get_quad_Public_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664192);
			GraphicsUtils.NativeMethodInfoPtr_Blit_Public_Static_Void_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664193);
			GraphicsUtils.NativeMethodInfoPtr_ClearAndBlit_Public_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664194);
			GraphicsUtils.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664195);
			GraphicsUtils.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664196);
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0008A4F0 File Offset: 0x000886F0
		public unsafe static bool isLinearColorSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78942, RefRangeEnd = 78943, XrefRangeStart = 78941, XrefRangeEnd = 78942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_get_isLinearColorSpace_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0008A520 File Offset: 0x00088720
		public unsafe static bool supportsDX11
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78943, XrefRangeEnd = 78944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_get_supportsDX11_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0008A550 File Offset: 0x00088750
		public unsafe static Texture2D whiteTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78944, XrefRangeEnd = 78962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0008A584 File Offset: 0x00088784
		public unsafe static Mesh quad
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78995, RefRangeEnd = 78997, XrefRangeStart = 78962, XrefRangeEnd = 78995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_get_quad_Public_Static_get_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0008A5B8 File Offset: 0x000887B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78997, XrefRangeEnd = 79012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Material material, int pass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_Blit_Public_Static_Void_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0008A5FC File Offset: 0x000887FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79012, XrefRangeEnd = 79034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAndBlit(Texture source, RenderTexture destination, Material material, int pass, bool clearColor = true, bool clearDepth = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_ClearAndBlit_Public_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0008A680 File Offset: 0x00088880
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 79041, RefRangeEnd = 79054, XrefRangeStart = 79034, XrefRangeEnd = 79041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0008A6B8 File Offset: 0x000888B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79054, XrefRangeEnd = 79057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00006977 File Offset: 0x00004B77
		public GraphicsUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0008A6E0 File Offset: 0x000888E0
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00006980 File Offset: 0x00004B80
		public unsafe static Texture2D s_WhiteTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicsUtils.NativeFieldInfoPtr_s_WhiteTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicsUtils.NativeFieldInfoPtr_s_WhiteTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x0008A708 File Offset: 0x00088908
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x00006992 File Offset: 0x00004B92
		public unsafe static Mesh s_Quad
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicsUtils.NativeFieldInfoPtr_s_Quad, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicsUtils.NativeFieldInfoPtr_s_Quad, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr_s_WhiteTexture;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeFieldInfoPtr_s_Quad;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_get_isLinearColorSpace_Public_Static_get_Boolean_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsDX11_Public_Static_get_Boolean_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_get_quad_Public_Static_get_Mesh_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Material_Int32_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_ClearAndBlit_Public_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_Boolean_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;
	}
}
