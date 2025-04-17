using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets;

namespace Il2CppScheduleOne.Management.Objects
{
	// Token: 0x020003B2 RID: 946
	public class ManageablePot : ManageableObject
	{
		// Token: 0x060049C3 RID: 18883 RVA: 0x0016707C File Offset: 0x0016527C
		// Note: this type is marked as 'beforefieldinit'.
		static ManageablePot()
		{
			Il2CppClassPointerStore<ManageablePot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Objects", "ManageablePot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr);
			ManageablePot.NativeFieldInfoPtr_CurrentPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, "CurrentPreset");
			ManageablePot.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672453);
			ManageablePot.NativeMethodInfoPtr_GetObjectType_Public_Virtual_ManageableObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672454);
			ManageablePot.NativeMethodInfoPtr_GetCurrentPreset_Public_Virtual_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672455);
			ManageablePot.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672456);
			ManageablePot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672457);
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x00167124 File Offset: 0x00165324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163537, XrefRangeEnd = 163539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x00167160 File Offset: 0x00165360
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ManageableObjectType GetObjectType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_GetObjectType_Public_Virtual_ManageableObjectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x001671A8 File Offset: 0x001653A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Preset GetCurrentPreset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_GetCurrentPreset_Public_Virtual_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x001671F4 File Offset: 0x001653F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163539, XrefRangeEnd = 163559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetPreset_Internal(Preset newPreset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPreset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x00167244 File Offset: 0x00165444
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManageablePot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManageablePot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x0002385E File Offset: 0x00021A5E
		public ManageablePot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x060049CA RID: 18890 RVA: 0x00167280 File Offset: 0x00165480
		// (set) Token: 0x060049CB RID: 18891 RVA: 0x00023867 File Offset: 0x00021A67
		public unsafe PotPreset CurrentPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManageablePot.NativeFieldInfoPtr_CurrentPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManageablePot.NativeFieldInfoPtr_CurrentPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031BF RID: 12735
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPreset;

		// Token: 0x040031C0 RID: 12736
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040031C1 RID: 12737
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectType_Public_Virtual_ManageableObjectType_0;

		// Token: 0x040031C2 RID: 12738
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPreset_Public_Virtual_Preset_0;

		// Token: 0x040031C3 RID: 12739
		private static readonly IntPtr NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_Void_Preset_0;

		// Token: 0x040031C4 RID: 12740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
