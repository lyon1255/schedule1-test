using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x0200018E RID: 398
	public class TVHomeScreen : TVApp
	{
		// Token: 0x06002064 RID: 8292 RVA: 0x000D532C File Offset: 0x000D352C
		// Note: this type is marked as 'beforefieldinit'.
		static TVHomeScreen()
		{
			Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVHomeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr);
			TVHomeScreen.NativeFieldInfoPtr_Interface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "Interface");
			TVHomeScreen.NativeFieldInfoPtr_Apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "Apps");
			TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "AppButtonContainer");
			TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "PlayerDisplays");
			TVHomeScreen.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "TimeLabel");
			TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "AppButtonPrefab");
			TVHomeScreen.NativeFieldInfoPtr_skipExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "skipExit");
			TVHomeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666914);
			TVHomeScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666915);
			TVHomeScreen.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666916);
			TVHomeScreen.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666917);
			TVHomeScreen.NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666918);
			TVHomeScreen.NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666919);
			TVHomeScreen.NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666920);
			TVHomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666921);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000D5488 File Offset: 0x000D3688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108789, XrefRangeEnd = 108847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000D54C4 File Offset: 0x000D36C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108847, XrefRangeEnd = 108849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000D5500 File Offset: 0x000D3700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108849, XrefRangeEnd = 108851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000D553C File Offset: 0x000D373C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108851, XrefRangeEnd = 108852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000D5578 File Offset: 0x000D3778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108858, RefRangeEnd = 108860, XrefRangeStart = 108852, XrefRangeEnd = 108858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000D55AC File Offset: 0x000D37AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108860, XrefRangeEnd = 108861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppSelected(TVApp app)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(app);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000D55F0 File Offset: 0x000D37F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108861, XrefRangeEnd = 108877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerChange(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000D5634 File Offset: 0x000D3834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVHomeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000123F1 File Offset: 0x000105F1
		public TVHomeScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x000D5670 File Offset: 0x000D3870
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x000123FA File Offset: 0x000105FA
		public unsafe TVInterface Interface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Interface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Interface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x000D56A0 File Offset: 0x000D38A0
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x00012419 File Offset: 0x00010619
		public unsafe Il2CppReferenceArray<TVApp> Apps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Apps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TVApp>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Apps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x000D56D0 File Offset: 0x000D38D0
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x00012438 File Offset: 0x00010638
		public unsafe RectTransform AppButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x000D5700 File Offset: 0x000D3900
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x00012457 File Offset: 0x00010657
		public unsafe Il2CppReferenceArray<RectTransform> PlayerDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x000D5730 File Offset: 0x000D3930
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x00012476 File Offset: 0x00010676
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x000D5760 File Offset: 0x000D3960
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00012495 File Offset: 0x00010695
		public unsafe GameObject AppButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x000D5790 File Offset: 0x000D3990
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x000124B4 File Offset: 0x000106B4
		public unsafe bool skipExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_skipExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_skipExit)) = value;
			}
		}

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeFieldInfoPtr_Interface;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeFieldInfoPtr_Apps;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeFieldInfoPtr_AppButtonContainer;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplays;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeFieldInfoPtr_AppButtonPrefab;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeFieldInfoPtr_skipExit;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B8 RID: 2232
		[ObfuscatedName("ScheduleOne.TV.TVHomeScreen+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C324 RID: 49956 RVA: 0x002F9D9C File Offset: 0x002F7F9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr);
				TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, "app");
				TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, 100666922);
				TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, 100666923);
			}

			// Token: 0x0600C325 RID: 49957 RVA: 0x002F9E18 File Offset: 0x002F8018
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C326 RID: 49958 RVA: 0x002F9E54 File Offset: 0x002F8054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108788, XrefRangeEnd = 108789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C327 RID: 49959 RVA: 0x0005EF77 File Offset: 0x0005D177
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CED RID: 15597
			// (get) Token: 0x0600C328 RID: 49960 RVA: 0x002F9E88 File Offset: 0x002F8088
			// (set) Token: 0x0600C329 RID: 49961 RVA: 0x0005EF80 File Offset: 0x0005D180
			public unsafe TVApp app
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CEE RID: 15598
			// (get) Token: 0x0600C32A RID: 49962 RVA: 0x002F9EB8 File Offset: 0x002F80B8
			// (set) Token: 0x0600C32B RID: 49963 RVA: 0x0005EF9F File Offset: 0x0005D19F
			public unsafe TVHomeScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVHomeScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400845B RID: 33883
			private static readonly IntPtr NativeFieldInfoPtr_app;

			// Token: 0x0400845C RID: 33884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400845D RID: 33885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400845E RID: 33886
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
