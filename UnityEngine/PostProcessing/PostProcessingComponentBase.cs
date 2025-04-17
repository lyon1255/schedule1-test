using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006F RID: 111
	public class PostProcessingComponentBase : Object
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x00088D1C File Offset: 0x00086F1C
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingComponentBase()
		{
			Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingComponentBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr);
			PostProcessingComponentBase.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, "context");
			PostProcessingComponentBase.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_New_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664153);
			PostProcessingComponentBase.NativeMethodInfoPtr_get_active_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664154);
			PostProcessingComponentBase.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664155);
			PostProcessingComponentBase.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664156);
			PostProcessingComponentBase.NativeMethodInfoPtr_GetModel_Public_Abstract_Virtual_New_PostProcessingModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664157);
			PostProcessingComponentBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664158);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00088DD8 File Offset: 0x00086FD8
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_New_DepthTextureMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00088E20 File Offset: 0x00087020
		public unsafe virtual bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_get_active_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00088E68 File Offset: 0x00087068
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00088EA4 File Offset: 0x000870A4
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00088EE0 File Offset: 0x000870E0
		[CallerCount(0)]
		public unsafe virtual PostProcessingModel GetModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_GetModel_Public_Abstract_Virtual_New_PostProcessingModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessingModel>(intPtr3) : null;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00088F2C File Offset: 0x0008712C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingComponentBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingComponentBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000065FE File Offset: 0x000047FE
		public PostProcessingComponentBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00088F68 File Offset: 0x00087168
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00006607 File Offset: 0x00004807
		public unsafe PostProcessingContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingComponentBase.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessingContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingComponentBase.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_New_DepthTextureMode_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_GetModel_Public_Abstract_Virtual_New_PostProcessingModel_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
