using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000073 RID: 115
	public class PostProcessingContext : Object
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x00089640 File Offset: 0x00087840
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingContext()
		{
			Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr);
			PostProcessingContext.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "profile");
			PostProcessingContext.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "camera");
			PostProcessingContext.NativeFieldInfoPtr_materialFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "materialFactory");
			PostProcessingContext.NativeFieldInfoPtr_renderTextureFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "renderTextureFactory");
			PostProcessingContext.NativeFieldInfoPtr__interrupted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "<interrupted>k__BackingField");
			PostProcessingContext.NativeMethodInfoPtr_get_interrupted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664170);
			PostProcessingContext.NativeMethodInfoPtr_set_interrupted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664171);
			PostProcessingContext.NativeMethodInfoPtr_Interrupt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664172);
			PostProcessingContext.NativeMethodInfoPtr_Reset_Public_PostProcessingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664173);
			PostProcessingContext.NativeMethodInfoPtr_get_isGBufferAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664174);
			PostProcessingContext.NativeMethodInfoPtr_get_isHdr_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664175);
			PostProcessingContext.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664176);
			PostProcessingContext.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664177);
			PostProcessingContext.NativeMethodInfoPtr_get_viewport_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664178);
			PostProcessingContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664179);
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0008979C File Offset: 0x0008799C
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x000897D8 File Offset: 0x000879D8
		public unsafe bool interrupted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_interrupted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_set_interrupted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00089818 File Offset: 0x00087A18
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77278, RefRangeEnd = 77287, XrefRangeStart = 77278, XrefRangeEnd = 77287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_Interrupt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0008984C File Offset: 0x00087A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78773, XrefRangeEnd = 78777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingContext Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_Reset_Public_PostProcessingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessingContext>(intPtr3) : null;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0008988C File Offset: 0x00087A8C
		public unsafe bool isGBufferAvailable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 78778, RefRangeEnd = 78782, XrefRangeStart = 78777, XrefRangeEnd = 78778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_isGBufferAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x000898C8 File Offset: 0x00087AC8
		public unsafe bool isHdr
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78784, RefRangeEnd = 78786, XrefRangeStart = 78782, XrefRangeEnd = 78784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_isHdr_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00089904 File Offset: 0x00087B04
		public unsafe int width
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 78788, RefRangeEnd = 78802, XrefRangeStart = 78786, XrefRangeEnd = 78788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00089940 File Offset: 0x00087B40
		public unsafe int height
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 78804, RefRangeEnd = 78818, XrefRangeStart = 78802, XrefRangeEnd = 78804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_height_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0008997C File Offset: 0x00087B7C
		public unsafe Rect viewport
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78819, RefRangeEnd = 78821, XrefRangeStart = 78818, XrefRangeEnd = 78819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_viewport_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000899B8 File Offset: 0x00087BB8
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingContext() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00006641 File Offset: 0x00004841
		public PostProcessingContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x000899F4 File Offset: 0x00087BF4
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x0000664A File Offset: 0x0000484A
		public unsafe PostProcessingProfile profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessingProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00089A24 File Offset: 0x00087C24
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00006669 File Offset: 0x00004869
		public unsafe Camera camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00089A54 File Offset: 0x00087C54
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00006688 File Offset: 0x00004888
		public unsafe MaterialFactory materialFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_materialFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_materialFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00089A84 File Offset: 0x00087C84
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x000066A7 File Offset: 0x000048A7
		public unsafe RenderTextureFactory renderTextureFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_renderTextureFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTextureFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_renderTextureFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00089AB4 File Offset: 0x00087CB4
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x000066C6 File Offset: 0x000048C6
		public unsafe bool _interrupted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr__interrupted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr__interrupted_k__BackingField)) = value;
			}
		}

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_profile;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_camera;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_materialFactory;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_renderTextureFactory;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr__interrupted_k__BackingField;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_get_interrupted_Public_get_Boolean_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_set_interrupted_Private_set_Void_Boolean_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Void_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_PostProcessingContext_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_get_isGBufferAvailable_Public_get_Boolean_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_get_isHdr_Public_get_Boolean_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_get_viewport_Public_get_Rect_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
