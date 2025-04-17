using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000061 RID: 97
	[Serializable]
	public class BloomModel : PostProcessingModel
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x0008665C File Offset: 0x0008485C
		// Note: this type is marked as 'beforefieldinit'.
		static BloomModel()
		{
			Il2CppClassPointerStore<BloomModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "BloomModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomModel>.NativeClassPtr);
			BloomModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, "m_Settings");
			BloomModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, 100664051);
			BloomModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, 100664052);
			BloomModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, 100664053);
			BloomModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, 100664054);
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x000866F0 File Offset: 0x000848F0
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00086728 File Offset: 0x00084928
		public unsafe BloomModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BloomModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new BloomModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77750, XrefRangeEnd = 77751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00086770 File Offset: 0x00084970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77751, XrefRangeEnd = 77754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BloomModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000867AC File Offset: 0x000849AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77754, XrefRangeEnd = 77758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BloomModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00006009 File Offset: 0x00004209
		public BloomModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000867E8 File Offset: 0x000849E8
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00006012 File Offset: 0x00004212
		public BloomModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.NativeFieldInfoPtr_m_Settings);
				return new BloomModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007E3 RID: 2019
		[Serializable]
		[StructLayout(2)]
		public struct BloomSettings
		{
			// Token: 0x0600BC53 RID: 48211 RVA: 0x002E721C File Offset: 0x002E541C
			// Note: this type is marked as 'beforefieldinit'.
			static BloomSettings()
			{
				Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, "BloomSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr);
				BloomModel.BloomSettings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "intensity");
				BloomModel.BloomSettings.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "threshold");
				BloomModel.BloomSettings.NativeFieldInfoPtr_softKnee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "softKnee");
				BloomModel.BloomSettings.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "radius");
				BloomModel.BloomSettings.NativeFieldInfoPtr_antiFlicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "antiFlicker");
				BloomModel.BloomSettings.NativeMethodInfoPtr_set_thresholdLinear_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, 100664055);
				BloomModel.BloomSettings.NativeMethodInfoPtr_get_thresholdLinear_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, 100664056);
				BloomModel.BloomSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BloomSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, 100664057);
			}

			// Token: 0x17003A59 RID: 14937
			// (get) Token: 0x0600BC55 RID: 48213 RVA: 0x002E731C File Offset: 0x002E551C
			// (set) Token: 0x0600BC54 RID: 48212 RVA: 0x002E72E8 File Offset: 0x002E54E8
			public unsafe float thresholdLinear
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 77746, RefRangeEnd = 77747, XrefRangeStart = 77745, XrefRangeEnd = 77746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.BloomSettings.NativeMethodInfoPtr_get_thresholdLinear_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77744, XrefRangeEnd = 77745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.BloomSettings.NativeMethodInfoPtr_set_thresholdLinear_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003A5A RID: 14938
			// (get) Token: 0x0600BC56 RID: 48214 RVA: 0x002E734C File Offset: 0x002E554C
			public unsafe static BloomModel.BloomSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.BloomSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BloomSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC57 RID: 48215 RVA: 0x0005C147 File Offset: 0x0005A347
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F06 RID: 32518
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007F07 RID: 32519
			private static readonly IntPtr NativeFieldInfoPtr_threshold;

			// Token: 0x04007F08 RID: 32520
			private static readonly IntPtr NativeFieldInfoPtr_softKnee;

			// Token: 0x04007F09 RID: 32521
			private static readonly IntPtr NativeFieldInfoPtr_radius;

			// Token: 0x04007F0A RID: 32522
			private static readonly IntPtr NativeFieldInfoPtr_antiFlicker;

			// Token: 0x04007F0B RID: 32523
			private static readonly IntPtr NativeMethodInfoPtr_set_thresholdLinear_Public_set_Void_Single_0;

			// Token: 0x04007F0C RID: 32524
			private static readonly IntPtr NativeMethodInfoPtr_get_thresholdLinear_Public_get_Single_0;

			// Token: 0x04007F0D RID: 32525
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BloomSettings_0;

			// Token: 0x04007F0E RID: 32526
			[FieldOffset(0)]
			public float intensity;

			// Token: 0x04007F0F RID: 32527
			[FieldOffset(4)]
			public float threshold;

			// Token: 0x04007F10 RID: 32528
			[FieldOffset(8)]
			public float softKnee;

			// Token: 0x04007F11 RID: 32529
			[FieldOffset(12)]
			public float radius;

			// Token: 0x04007F12 RID: 32530
			[FieldOffset(16)]
			[MarshalAs(4)]
			public bool antiFlicker;
		}

		// Token: 0x020007E4 RID: 2020
		[Serializable]
		public sealed class LensDirtSettings : ValueType
		{
			// Token: 0x0600BC58 RID: 48216 RVA: 0x002E737C File Offset: 0x002E557C
			// Note: this type is marked as 'beforefieldinit'.
			static LensDirtSettings()
			{
				Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, "LensDirtSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr);
				BloomModel.LensDirtSettings.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, "texture");
				BloomModel.LensDirtSettings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, "intensity");
				BloomModel.LensDirtSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LensDirtSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, 100664058);
			}

			// Token: 0x17003A5D RID: 14941
			// (get) Token: 0x0600BC59 RID: 48217 RVA: 0x002E73E4 File Offset: 0x002E55E4
			public unsafe static BloomModel.LensDirtSettings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77747, XrefRangeEnd = 77748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BloomModel.LensDirtSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LensDirtSettings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new BloomModel.LensDirtSettings(pointer);
				}
			}

			// Token: 0x0600BC5A RID: 48218 RVA: 0x0005C159 File Offset: 0x0005A359
			public LensDirtSettings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BC5B RID: 48219 RVA: 0x0005C162 File Offset: 0x0005A362
			public LensDirtSettings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A5B RID: 14939
			// (get) Token: 0x0600BC5C RID: 48220 RVA: 0x002E7410 File Offset: 0x002E5610
			// (set) Token: 0x0600BC5D RID: 48221 RVA: 0x0005C174 File Offset: 0x0005A374
			public unsafe Texture texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.LensDirtSettings.NativeFieldInfoPtr_texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.LensDirtSettings.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A5C RID: 14940
			// (get) Token: 0x0600BC5E RID: 48222 RVA: 0x002E7440 File Offset: 0x002E5640
			// (set) Token: 0x0600BC5F RID: 48223 RVA: 0x0005C193 File Offset: 0x0005A393
			public unsafe float intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.LensDirtSettings.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.LensDirtSettings.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x04007F13 RID: 32531
			private static readonly IntPtr NativeFieldInfoPtr_texture;

			// Token: 0x04007F14 RID: 32532
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007F15 RID: 32533
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LensDirtSettings_0;
		}

		// Token: 0x020007E5 RID: 2021
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BC60 RID: 48224 RVA: 0x002E7468 File Offset: 0x002E5668
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr);
				BloomModel.Settings.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, "bloom");
				BloomModel.Settings.NativeFieldInfoPtr_lensDirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, "lensDirt");
				BloomModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, 100664059);
			}

			// Token: 0x17003A60 RID: 14944
			// (get) Token: 0x0600BC61 RID: 48225 RVA: 0x002E74D0 File Offset: 0x002E56D0
			public unsafe static BloomModel.Settings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77748, XrefRangeEnd = 77750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BloomModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new BloomModel.Settings(pointer);
				}
			}

			// Token: 0x0600BC62 RID: 48226 RVA: 0x0005C1AE File Offset: 0x0005A3AE
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BC63 RID: 48227 RVA: 0x0005C1B7 File Offset: 0x0005A3B7
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A5E RID: 14942
			// (get) Token: 0x0600BC64 RID: 48228 RVA: 0x002E74FC File Offset: 0x002E56FC
			// (set) Token: 0x0600BC65 RID: 48229 RVA: 0x0005C1C9 File Offset: 0x0005A3C9
			public unsafe BloomModel.BloomSettings bloom
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.Settings.NativeFieldInfoPtr_bloom);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.Settings.NativeFieldInfoPtr_bloom)) = value;
				}
			}

			// Token: 0x17003A5F RID: 14943
			// (get) Token: 0x0600BC66 RID: 48230 RVA: 0x002E7524 File Offset: 0x002E5724
			// (set) Token: 0x0600BC67 RID: 48231 RVA: 0x0005C1E4 File Offset: 0x0005A3E4
			public BloomModel.LensDirtSettings lensDirt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.Settings.NativeFieldInfoPtr_lensDirt);
					return new BloomModel.LensDirtSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.Settings.NativeFieldInfoPtr_lensDirt), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007F16 RID: 32534
			private static readonly IntPtr NativeFieldInfoPtr_bloom;

			// Token: 0x04007F17 RID: 32535
			private static readonly IntPtr NativeFieldInfoPtr_lensDirt;

			// Token: 0x04007F18 RID: 32536
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
