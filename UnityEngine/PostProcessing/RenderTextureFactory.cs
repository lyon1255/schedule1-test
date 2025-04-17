﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000079 RID: 121
	public sealed class RenderTextureFactory : Object
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x0008A8A0 File Offset: 0x00088AA0
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTextureFactory()
		{
			Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "RenderTextureFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr);
			RenderTextureFactory.NativeFieldInfoPtr_m_TemporaryRTs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr, "m_TemporaryRTs");
			RenderTextureFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr, 100664200);
			RenderTextureFactory.NativeMethodInfoPtr_Get_Public_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr, 100664201);
			RenderTextureFactory.NativeMethodInfoPtr_Get_Public_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_FilterMode_TextureWrapMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr, 100664202);
			RenderTextureFactory.NativeMethodInfoPtr_Release_Public_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr, 100664203);
			RenderTextureFactory.NativeMethodInfoPtr_ReleaseAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr, 100664204);
			RenderTextureFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr, 100664205);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0008A95C File Offset: 0x00088B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79131, XrefRangeEnd = 79146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureFactory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTextureFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0008A998 File Offset: 0x00088B98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79160, RefRangeEnd = 79162, XrefRangeStart = 79146, XrefRangeEnd = 79160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture Get(RenderTexture baseRenderTexture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseRenderTexture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureFactory.NativeMethodInfoPtr_Get_Public_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0008A9E8 File Offset: 0x00088BE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 79169, RefRangeEnd = 79176, XrefRangeStart = 79162, XrefRangeEnd = 79169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture Get(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite rw = RenderTextureReadWrite.Default, FilterMode filterMode = FilterMode.Bilinear, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "FactoryTempTexture")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rw;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureFactory.NativeMethodInfoPtr_Get_Public_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_FilterMode_TextureWrapMode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0008AA9C File Offset: 0x00088C9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 79187, RefRangeEnd = 79193, XrefRangeStart = 79176, XrefRangeEnd = 79187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(RenderTexture rt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureFactory.NativeMethodInfoPtr_Release_Public_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0008AAE0 File Offset: 0x00088CE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79206, RefRangeEnd = 79209, XrefRangeStart = 79193, XrefRangeEnd = 79206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureFactory.NativeMethodInfoPtr_ReleaseAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0008AB14 File Offset: 0x00088D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79209, XrefRangeEnd = 79210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000069CC File Offset: 0x00004BCC
		public RenderTextureFactory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0008AB48 File Offset: 0x00088D48
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x000069D5 File Offset: 0x00004BD5
		public unsafe HashSet<RenderTexture> m_TemporaryRTs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureFactory.NativeFieldInfoPtr_m_TemporaryRTs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureFactory.NativeFieldInfoPtr_m_TemporaryRTs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeFieldInfoPtr_m_TemporaryRTs;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_RenderTexture_RenderTexture_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_FilterMode_TextureWrapMode_String_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_RenderTexture_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAll_Public_Void_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
