using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000074 RID: 116
	[Serializable]
	public class PostProcessingModel : Object
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x00089ADC File Offset: 0x00087CDC
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingModel()
		{
			Il2CppClassPointerStore<PostProcessingModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingModel>.NativeClassPtr);
			PostProcessingModel.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingModel>.NativeClassPtr, "m_Enabled");
			PostProcessingModel.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingModel>.NativeClassPtr, 100664180);
			PostProcessingModel.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingModel>.NativeClassPtr, 100664181);
			PostProcessingModel.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingModel>.NativeClassPtr, 100664182);
			PostProcessingModel.NativeMethodInfoPtr_OnValidate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingModel>.NativeClassPtr, 100664183);
			PostProcessingModel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingModel>.NativeClassPtr, 100664184);
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00089B84 File Offset: 0x00087D84
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00089BC0 File Offset: 0x00087DC0
		public unsafe bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingModel.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingModel.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00089C00 File Offset: 0x00087E00
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingModel.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00089C3C File Offset: 0x00087E3C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingModel.NativeMethodInfoPtr_OnValidate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00089C78 File Offset: 0x00087E78
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingModel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000066E1 File Offset: 0x000048E1
		public PostProcessingModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00089CB4 File Offset: 0x00087EB4
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x000066EA File Offset: 0x000048EA
		public unsafe bool m_Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingModel.NativeFieldInfoPtr_m_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingModel.NativeFieldInfoPtr_m_Enabled)) = value;
			}
		}

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Virtual_New_Void_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
