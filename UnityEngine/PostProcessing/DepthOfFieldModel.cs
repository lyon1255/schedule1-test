using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000065 RID: 101
	[Serializable]
	public class DepthOfFieldModel : PostProcessingModel
	{
		// Token: 0x0600076D RID: 1901 RVA: 0x00087010 File Offset: 0x00085210
		// Note: this type is marked as 'beforefieldinit'.
		static DepthOfFieldModel()
		{
			Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "DepthOfFieldModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr);
			DepthOfFieldModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, "m_Settings");
			DepthOfFieldModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, 100664091);
			DepthOfFieldModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, 100664092);
			DepthOfFieldModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, 100664093);
			DepthOfFieldModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, 100664094);
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x000870A4 File Offset: 0x000852A4
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x000870E0 File Offset: 0x000852E0
		public unsafe DepthOfFieldModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00087120 File Offset: 0x00085320
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DepthOfFieldModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0008715C File Offset: 0x0008535C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77878, XrefRangeEnd = 77879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthOfFieldModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0000610C File Offset: 0x0000430C
		public DepthOfFieldModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00087198 File Offset: 0x00085398
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00006115 File Offset: 0x00004315
		public unsafe DepthOfFieldModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007F5 RID: 2037
		[OriginalName("Assembly-CSharp.dll", "", "KernelSize")]
		public enum KernelSize
		{
			// Token: 0x04007F94 RID: 32660
			Small,
			// Token: 0x04007F95 RID: 32661
			Medium,
			// Token: 0x04007F96 RID: 32662
			Large,
			// Token: 0x04007F97 RID: 32663
			VeryLarge
		}

		// Token: 0x020007F6 RID: 2038
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCB7 RID: 48311 RVA: 0x002E8258 File Offset: 0x002E6458
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr);
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_focusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "focusDistance");
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_aperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "aperture");
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_focalLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "focalLength");
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_useCameraFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "useCameraFov");
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_kernelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "kernelSize");
				DepthOfFieldModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, 100664095);
			}

			// Token: 0x17003A81 RID: 14977
			// (get) Token: 0x0600BCB8 RID: 48312 RVA: 0x002E82FC File Offset: 0x002E64FC
			public unsafe static DepthOfFieldModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCB9 RID: 48313 RVA: 0x0005C558 File Offset: 0x0005A758
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F98 RID: 32664
			private static readonly IntPtr NativeFieldInfoPtr_focusDistance;

			// Token: 0x04007F99 RID: 32665
			private static readonly IntPtr NativeFieldInfoPtr_aperture;

			// Token: 0x04007F9A RID: 32666
			private static readonly IntPtr NativeFieldInfoPtr_focalLength;

			// Token: 0x04007F9B RID: 32667
			private static readonly IntPtr NativeFieldInfoPtr_useCameraFov;

			// Token: 0x04007F9C RID: 32668
			private static readonly IntPtr NativeFieldInfoPtr_kernelSize;

			// Token: 0x04007F9D RID: 32669
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007F9E RID: 32670
			[FieldOffset(0)]
			public float focusDistance;

			// Token: 0x04007F9F RID: 32671
			[FieldOffset(4)]
			public float aperture;

			// Token: 0x04007FA0 RID: 32672
			[FieldOffset(8)]
			public float focalLength;

			// Token: 0x04007FA1 RID: 32673
			[FieldOffset(12)]
			[MarshalAs(4)]
			public bool useCameraFov;

			// Token: 0x04007FA2 RID: 32674
			[FieldOffset(16)]
			public DepthOfFieldModel.KernelSize kernelSize;
		}
	}
}
