using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000068 RID: 104
	[Serializable]
	public class FogModel : PostProcessingModel
	{
		// Token: 0x06000785 RID: 1925 RVA: 0x00087520 File Offset: 0x00085720
		// Note: this type is marked as 'beforefieldinit'.
		static FogModel()
		{
			Il2CppClassPointerStore<FogModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "FogModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogModel>.NativeClassPtr);
			FogModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogModel>.NativeClassPtr, "m_Settings");
			FogModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel>.NativeClassPtr, 100664106);
			FogModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel>.NativeClassPtr, 100664107);
			FogModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel>.NativeClassPtr, 100664108);
			FogModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel>.NativeClassPtr, 100664109);
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000875B4 File Offset: 0x000857B4
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x000875F0 File Offset: 0x000857F0
		public unsafe FogModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00087630 File Offset: 0x00085830
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 42605, RefRangeEnd = 42616, XrefRangeStart = 42605, XrefRangeEnd = 42616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FogModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0008766C File Offset: 0x0008586C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77881, XrefRangeEnd = 77882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FogModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00006178 File Offset: 0x00004378
		public FogModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x000876A8 File Offset: 0x000858A8
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00006181 File Offset: 0x00004381
		public unsafe FogModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FogModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FogModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007FA RID: 2042
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCC0 RID: 48320 RVA: 0x002E84A8 File Offset: 0x002E66A8
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FogModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr);
				FogModel.Settings.NativeFieldInfoPtr_excludeSkybox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr, "excludeSkybox");
				FogModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr, 100664110);
			}

			// Token: 0x17003A84 RID: 14980
			// (get) Token: 0x0600BCC1 RID: 48321 RVA: 0x002E84FC File Offset: 0x002E66FC
			public unsafe static FogModel.Settings defaultSettings
			{
				[CallerCount(20)]
				[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCC2 RID: 48322 RVA: 0x0005C5C2 File Offset: 0x0005A7C2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FBE RID: 32702
			private static readonly IntPtr NativeFieldInfoPtr_excludeSkybox;

			// Token: 0x04007FBF RID: 32703
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FC0 RID: 32704
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool excludeSkybox;
		}
	}
}
