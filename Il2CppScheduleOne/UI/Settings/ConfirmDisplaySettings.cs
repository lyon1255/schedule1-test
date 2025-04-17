using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000686 RID: 1670
	public class ConfirmDisplaySettings : MonoBehaviour
	{
		// Token: 0x06009597 RID: 38295 RVA: 0x00265984 File Offset: 0x00263B84
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmDisplaySettings()
		{
			Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "ConfirmDisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr);
			ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "RevertTime");
			ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "SubtitleLabel");
			ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "timeUntilRevert");
			ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "oldSettings");
			ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "newSettings");
			ConfirmDisplaySettings.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681785);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681786);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681787);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681788);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681789);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681790);
			ConfirmDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681791);
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x06009598 RID: 38296 RVA: 0x00265AA4 File Offset: 0x00263CA4
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268616, XrefRangeEnd = 268626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06009599 RID: 38297 RVA: 0x00265AE0 File Offset: 0x00263CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268626, XrefRangeEnd = 268639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600959A RID: 38298 RVA: 0x00265B14 File Offset: 0x00263D14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268649, RefRangeEnd = 268650, XrefRangeStart = 268639, XrefRangeEnd = 268649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(DisplaySettings _oldSettings, DisplaySettings _newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _oldSettings;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _newSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600959B RID: 38299 RVA: 0x00265B60 File Offset: 0x00263D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268650, XrefRangeEnd = 268661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x00265BA4 File Offset: 0x00263DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268661, XrefRangeEnd = 268669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600959D RID: 38301 RVA: 0x00265BD8 File Offset: 0x00263DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268695, RefRangeEnd = 268698, XrefRangeStart = 268669, XrefRangeEnd = 268695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool revert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref revert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600959E RID: 38302 RVA: 0x00265C18 File Offset: 0x00263E18
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmDisplaySettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600959F RID: 38303 RVA: 0x00048B9B File Offset: 0x00046D9B
		public ConfirmDisplaySettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x060095A0 RID: 38304 RVA: 0x00265C54 File Offset: 0x00263E54
		// (set) Token: 0x060095A1 RID: 38305 RVA: 0x00048BA4 File Offset: 0x00046DA4
		public unsafe static float RevertTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime, (void*)(&value));
			}
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x060095A2 RID: 38306 RVA: 0x00265C70 File Offset: 0x00263E70
		// (set) Token: 0x060095A3 RID: 38307 RVA: 0x00048BB2 File Offset: 0x00046DB2
		public unsafe TextMeshProUGUI SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x060095A4 RID: 38308 RVA: 0x00265CA0 File Offset: 0x00263EA0
		// (set) Token: 0x060095A5 RID: 38309 RVA: 0x00048BD1 File Offset: 0x00046DD1
		public unsafe float timeUntilRevert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert)) = value;
			}
		}

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x060095A6 RID: 38310 RVA: 0x00265CC8 File Offset: 0x00263EC8
		// (set) Token: 0x060095A7 RID: 38311 RVA: 0x00048BEC File Offset: 0x00046DEC
		public unsafe DisplaySettings oldSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings)) = value;
			}
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x060095A8 RID: 38312 RVA: 0x00265CF0 File Offset: 0x00263EF0
		// (set) Token: 0x060095A9 RID: 38313 RVA: 0x00048C07 File Offset: 0x00046E07
		public unsafe DisplaySettings newSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings)) = value;
			}
		}

		// Token: 0x040064DF RID: 25823
		private static readonly IntPtr NativeFieldInfoPtr_RevertTime;

		// Token: 0x040064E0 RID: 25824
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x040064E1 RID: 25825
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilRevert;

		// Token: 0x040064E2 RID: 25826
		private static readonly IntPtr NativeFieldInfoPtr_oldSettings;

		// Token: 0x040064E3 RID: 25827
		private static readonly IntPtr NativeFieldInfoPtr_newSettings;

		// Token: 0x040064E4 RID: 25828
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040064E5 RID: 25829
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040064E6 RID: 25830
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0;

		// Token: 0x040064E7 RID: 25831
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040064E8 RID: 25832
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040064E9 RID: 25833
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x040064EA RID: 25834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
