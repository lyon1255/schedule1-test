using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006C RID: 108
	[Serializable]
	public class UserLutModel : PostProcessingModel
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x00087BE0 File Offset: 0x00085DE0
		// Note: this type is marked as 'beforefieldinit'.
		static UserLutModel()
		{
			Il2CppClassPointerStore<UserLutModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "UserLutModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr);
			UserLutModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, "m_Settings");
			UserLutModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, 100664126);
			UserLutModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, 100664127);
			UserLutModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, 100664128);
			UserLutModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, 100664129);
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00087C74 File Offset: 0x00085E74
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00087CAC File Offset: 0x00085EAC
		public unsafe UserLutModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UserLutModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UserLutModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00087CF4 File Offset: 0x00085EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77886, XrefRangeEnd = 77888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserLutModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00087D30 File Offset: 0x00085F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77888, XrefRangeEnd = 77891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserLutModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00006208 File Offset: 0x00004408
		public UserLutModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00087D6C File Offset: 0x00085F6C
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x00006211 File Offset: 0x00004411
		public UserLutModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.NativeFieldInfoPtr_m_Settings);
				return new UserLutModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000803 RID: 2051
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BCD2 RID: 48338 RVA: 0x002E888C File Offset: 0x002E6A8C
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr);
				UserLutModel.Settings.NativeFieldInfoPtr_lut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, "lut");
				UserLutModel.Settings.NativeFieldInfoPtr_contribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, "contribution");
				UserLutModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, 100664130);
			}

			// Token: 0x17003A8A RID: 14986
			// (get) Token: 0x0600BCD3 RID: 48339 RVA: 0x002E88F4 File Offset: 0x002E6AF4
			public unsafe static UserLutModel.Settings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77885, XrefRangeEnd = 77886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UserLutModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new UserLutModel.Settings(pointer);
				}
			}

			// Token: 0x0600BCD4 RID: 48340 RVA: 0x0005C674 File Offset: 0x0005A874
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BCD5 RID: 48341 RVA: 0x0005C67D File Offset: 0x0005A87D
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A88 RID: 14984
			// (get) Token: 0x0600BCD6 RID: 48342 RVA: 0x002E8920 File Offset: 0x002E6B20
			// (set) Token: 0x0600BCD7 RID: 48343 RVA: 0x0005C68F File Offset: 0x0005A88F
			public unsafe Texture2D lut
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.Settings.NativeFieldInfoPtr_lut);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.Settings.NativeFieldInfoPtr_lut), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A89 RID: 14985
			// (get) Token: 0x0600BCD8 RID: 48344 RVA: 0x002E8950 File Offset: 0x002E6B50
			// (set) Token: 0x0600BCD9 RID: 48345 RVA: 0x0005C6AE File Offset: 0x0005A8AE
			public unsafe float contribution
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.Settings.NativeFieldInfoPtr_contribution);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.Settings.NativeFieldInfoPtr_contribution)) = value;
				}
			}

			// Token: 0x04007FF8 RID: 32760
			private static readonly IntPtr NativeFieldInfoPtr_lut;

			// Token: 0x04007FF9 RID: 32761
			private static readonly IntPtr NativeFieldInfoPtr_contribution;

			// Token: 0x04007FFA RID: 32762
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
