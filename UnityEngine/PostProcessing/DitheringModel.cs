using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000066 RID: 102
	[Serializable]
	public class DitheringModel : PostProcessingModel
	{
		// Token: 0x06000775 RID: 1909 RVA: 0x000871C0 File Offset: 0x000853C0
		// Note: this type is marked as 'beforefieldinit'.
		static DitheringModel()
		{
			Il2CppClassPointerStore<DitheringModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "DitheringModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr);
			DitheringModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, "m_Settings");
			DitheringModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, 100664096);
			DitheringModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, 100664097);
			DitheringModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, 100664098);
			DitheringModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, 100664099);
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00087254 File Offset: 0x00085454
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00087290 File Offset: 0x00085490
		public unsafe DitheringModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x000872D0 File Offset: 0x000854D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42635, RefRangeEnd = 42637, XrefRangeStart = 42635, XrefRangeEnd = 42637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DitheringModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0008730C File Offset: 0x0008550C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77879, XrefRangeEnd = 77880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DitheringModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00006130 File Offset: 0x00004330
		public DitheringModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00087348 File Offset: 0x00085548
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00006139 File Offset: 0x00004339
		public unsafe DitheringModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007F7 RID: 2039
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCBA RID: 48314 RVA: 0x0005C56A File Offset: 0x0005A76A
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<DitheringModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DitheringModel.Settings>.NativeClassPtr);
				DitheringModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel.Settings>.NativeClassPtr, 100664100);
			}

			// Token: 0x17003A82 RID: 14978
			// (get) Token: 0x0600BCBB RID: 48315 RVA: 0x002E832C File Offset: 0x002E652C
			public unsafe static DitheringModel.Settings defaultSettings
			{
				[CallerCount(183)]
				[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCBC RID: 48316 RVA: 0x0005C59E File Offset: 0x0005A79E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DitheringModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FA3 RID: 32675
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
