using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000062 RID: 98
	[Serializable]
	public class BuiltinDebugViewsModel : PostProcessingModel
	{
		// Token: 0x0600074A RID: 1866 RVA: 0x00086818 File Offset: 0x00084A18
		// Note: this type is marked as 'beforefieldinit'.
		static BuiltinDebugViewsModel()
		{
			Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "BuiltinDebugViewsModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr);
			BuiltinDebugViewsModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, "m_Settings");
			BuiltinDebugViewsModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664060);
			BuiltinDebugViewsModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664061);
			BuiltinDebugViewsModel.NativeMethodInfoPtr_get_willInterrupt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664062);
			BuiltinDebugViewsModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664063);
			BuiltinDebugViewsModel.NativeMethodInfoPtr_IsModeActive_Public_Boolean_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664064);
			BuiltinDebugViewsModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664065);
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x000868D4 File Offset: 0x00084AD4
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00086910 File Offset: 0x00084B10
		public unsafe BuiltinDebugViewsModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00086950 File Offset: 0x00084B50
		public unsafe bool willInterrupt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr_get_willInterrupt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0008698C File Offset: 0x00084B8C
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuiltinDebugViewsModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000869C8 File Offset: 0x00084BC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 77758, RefRangeEnd = 77766, XrefRangeStart = 77758, XrefRangeEnd = 77758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsModeActive(BuiltinDebugViewsModel.Mode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr_IsModeActive_Public_Boolean_Mode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00086A14 File Offset: 0x00084C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77766, XrefRangeEnd = 77767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuiltinDebugViewsModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00006040 File Offset: 0x00004240
		public BuiltinDebugViewsModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00086A50 File Offset: 0x00084C50
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00006049 File Offset: 0x00004249
		public unsafe BuiltinDebugViewsModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_get_willInterrupt_Public_get_Boolean_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_IsModeActive_Public_Boolean_Mode_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007E6 RID: 2022
		[Serializable]
		[StructLayout(2)]
		public struct DepthSettings
		{
			// Token: 0x0600BC68 RID: 48232 RVA: 0x002E7554 File Offset: 0x002E5754
			// Note: this type is marked as 'beforefieldinit'.
			static DepthSettings()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, "DepthSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr);
				BuiltinDebugViewsModel.DepthSettings.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr, "scale");
				BuiltinDebugViewsModel.DepthSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_DepthSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr, 100664066);
			}

			// Token: 0x17003A61 RID: 14945
			// (get) Token: 0x0600BC69 RID: 48233 RVA: 0x002E75A8 File Offset: 0x002E57A8
			public unsafe static BuiltinDebugViewsModel.DepthSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.DepthSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_DepthSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC6A RID: 48234 RVA: 0x0005C212 File Offset: 0x0005A412
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F19 RID: 32537
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x04007F1A RID: 32538
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_DepthSettings_0;

			// Token: 0x04007F1B RID: 32539
			[FieldOffset(0)]
			public float scale;
		}

		// Token: 0x020007E7 RID: 2023
		[Serializable]
		[StructLayout(2)]
		public struct MotionVectorsSettings
		{
			// Token: 0x0600BC6B RID: 48235 RVA: 0x002E75D8 File Offset: 0x002E57D8
			// Note: this type is marked as 'beforefieldinit'.
			static MotionVectorsSettings()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, "MotionVectorsSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr);
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_sourceOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "sourceOpacity");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionImageOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionImageOpacity");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionImageAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionImageAmplitude");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionVectorsOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionVectorsOpacity");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionVectorsResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionVectorsResolution");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionVectorsAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionVectorsAmplitude");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_MotionVectorsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, 100664067);
			}

			// Token: 0x17003A62 RID: 14946
			// (get) Token: 0x0600BC6C RID: 48236 RVA: 0x002E7690 File Offset: 0x002E5890
			public unsafe static BuiltinDebugViewsModel.MotionVectorsSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.MotionVectorsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_MotionVectorsSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC6D RID: 48237 RVA: 0x0005C224 File Offset: 0x0005A424
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F1C RID: 32540
			private static readonly IntPtr NativeFieldInfoPtr_sourceOpacity;

			// Token: 0x04007F1D RID: 32541
			private static readonly IntPtr NativeFieldInfoPtr_motionImageOpacity;

			// Token: 0x04007F1E RID: 32542
			private static readonly IntPtr NativeFieldInfoPtr_motionImageAmplitude;

			// Token: 0x04007F1F RID: 32543
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorsOpacity;

			// Token: 0x04007F20 RID: 32544
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorsResolution;

			// Token: 0x04007F21 RID: 32545
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorsAmplitude;

			// Token: 0x04007F22 RID: 32546
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_MotionVectorsSettings_0;

			// Token: 0x04007F23 RID: 32547
			[FieldOffset(0)]
			public float sourceOpacity;

			// Token: 0x04007F24 RID: 32548
			[FieldOffset(4)]
			public float motionImageOpacity;

			// Token: 0x04007F25 RID: 32549
			[FieldOffset(8)]
			public float motionImageAmplitude;

			// Token: 0x04007F26 RID: 32550
			[FieldOffset(12)]
			public float motionVectorsOpacity;

			// Token: 0x04007F27 RID: 32551
			[FieldOffset(16)]
			public int motionVectorsResolution;

			// Token: 0x04007F28 RID: 32552
			[FieldOffset(20)]
			public float motionVectorsAmplitude;
		}

		// Token: 0x020007E8 RID: 2024
		[OriginalName("Assembly-CSharp.dll", "", "Mode")]
		public enum Mode
		{
			// Token: 0x04007F2A RID: 32554
			None,
			// Token: 0x04007F2B RID: 32555
			Depth,
			// Token: 0x04007F2C RID: 32556
			Normals,
			// Token: 0x04007F2D RID: 32557
			MotionVectors,
			// Token: 0x04007F2E RID: 32558
			AmbientOcclusion,
			// Token: 0x04007F2F RID: 32559
			EyeAdaptation,
			// Token: 0x04007F30 RID: 32560
			FocusPlane,
			// Token: 0x04007F31 RID: 32561
			PreGradingLog,
			// Token: 0x04007F32 RID: 32562
			LogLut,
			// Token: 0x04007F33 RID: 32563
			UserLut
		}

		// Token: 0x020007E9 RID: 2025
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BC6E RID: 48238 RVA: 0x002E76C0 File Offset: 0x002E58C0
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr);
				BuiltinDebugViewsModel.Settings.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, "mode");
				BuiltinDebugViewsModel.Settings.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, "depth");
				BuiltinDebugViewsModel.Settings.NativeFieldInfoPtr_motionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, "motionVectors");
				BuiltinDebugViewsModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, 100664068);
			}

			// Token: 0x17003A63 RID: 14947
			// (get) Token: 0x0600BC6F RID: 48239 RVA: 0x002E773C File Offset: 0x002E593C
			public unsafe static BuiltinDebugViewsModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC70 RID: 48240 RVA: 0x0005C236 File Offset: 0x0005A436
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F34 RID: 32564
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04007F35 RID: 32565
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x04007F36 RID: 32566
			private static readonly IntPtr NativeFieldInfoPtr_motionVectors;

			// Token: 0x04007F37 RID: 32567
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007F38 RID: 32568
			[FieldOffset(0)]
			public BuiltinDebugViewsModel.Mode mode;

			// Token: 0x04007F39 RID: 32569
			[FieldOffset(4)]
			public BuiltinDebugViewsModel.DepthSettings depth;

			// Token: 0x04007F3A RID: 32570
			[FieldOffset(8)]
			public BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;
		}
	}
}
