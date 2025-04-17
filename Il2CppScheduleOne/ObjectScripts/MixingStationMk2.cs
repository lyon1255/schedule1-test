using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200074D RID: 1869
	public class MixingStationMk2 : MixingStation
	{
		// Token: 0x0600B048 RID: 45128 RVA: 0x002BF8BC File Offset: 0x002BDABC
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationMk2()
		{
			Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "MixingStationMk2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr);
			MixingStationMk2.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "Animation");
			MixingStationMk2.NativeFieldInfoPtr_ScreenCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "ScreenCanvas");
			MixingStationMk2.NativeFieldInfoPtr_OutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "OutputIcon");
			MixingStationMk2.NativeFieldInfoPtr_QuestionMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "QuestionMark");
			MixingStationMk2.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "QuantityLabel");
			MixingStationMk2.NativeFieldInfoPtr_ProgressLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "ProgressLabel");
			MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted");
			MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted");
			MixingStationMk2.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684983);
			MixingStationMk2.NativeMethodInfoPtr_MixingStart_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684984);
			MixingStationMk2.NativeMethodInfoPtr_MixingDone_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684985);
			MixingStationMk2.NativeMethodInfoPtr_EnableScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684986);
			MixingStationMk2.NativeMethodInfoPtr_UpdateScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684987);
			MixingStationMk2.NativeMethodInfoPtr_DisableScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684988);
			MixingStationMk2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684989);
			MixingStationMk2.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684990);
			MixingStationMk2.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684991);
			MixingStationMk2.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684992);
			MixingStationMk2.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684993);
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x002BFA68 File Offset: 0x002BDC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303963, XrefRangeEnd = 303965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x002BFAA4 File Offset: 0x002BDCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303965, XrefRangeEnd = 303972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MixingStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_MixingStart_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B04B RID: 45131 RVA: 0x002BFAE0 File Offset: 0x002BDCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303972, XrefRangeEnd = 303980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MixingDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_MixingDone_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B04C RID: 45132 RVA: 0x002BFB1C File Offset: 0x002BDD1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303994, RefRangeEnd = 303995, XrefRangeStart = 303980, XrefRangeEnd = 303994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationMk2.NativeMethodInfoPtr_EnableScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x002BFB50 File Offset: 0x002BDD50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303999, RefRangeEnd = 304001, XrefRangeStart = 303995, XrefRangeEnd = 303999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationMk2.NativeMethodInfoPtr_UpdateScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B04E RID: 45134 RVA: 0x002BFB84 File Offset: 0x002BDD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304001, XrefRangeEnd = 304003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationMk2.NativeMethodInfoPtr_DisableScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B04F RID: 45135 RVA: 0x002BFBB8 File Offset: 0x002BDDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationMk2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationMk2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B050 RID: 45136 RVA: 0x002BFBF4 File Offset: 0x002BDDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304003, XrefRangeEnd = 304004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B051 RID: 45137 RVA: 0x002BFC30 File Offset: 0x002BDE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304004, XrefRangeEnd = 304005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B052 RID: 45138 RVA: 0x002BFC6C File Offset: 0x002BDE6C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x002BFCA8 File Offset: 0x002BDEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304005, XrefRangeEnd = 304006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x0005693A File Offset: 0x00054B3A
		public MixingStationMk2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600B055 RID: 45141 RVA: 0x002BFCE4 File Offset: 0x002BDEE4
		// (set) Token: 0x0600B056 RID: 45142 RVA: 0x00056943 File Offset: 0x00054B43
		public unsafe Animation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0600B057 RID: 45143 RVA: 0x002BFD14 File Offset: 0x002BDF14
		// (set) Token: 0x0600B058 RID: 45144 RVA: 0x00056962 File Offset: 0x00054B62
		public unsafe Canvas ScreenCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_ScreenCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_ScreenCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0600B059 RID: 45145 RVA: 0x002BFD44 File Offset: 0x002BDF44
		// (set) Token: 0x0600B05A RID: 45146 RVA: 0x00056981 File Offset: 0x00054B81
		public unsafe Image OutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_OutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_OutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0600B05B RID: 45147 RVA: 0x002BFD74 File Offset: 0x002BDF74
		// (set) Token: 0x0600B05C RID: 45148 RVA: 0x000569A0 File Offset: 0x00054BA0
		public unsafe RectTransform QuestionMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_QuestionMark);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_QuestionMark), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0600B05D RID: 45149 RVA: 0x002BFDA4 File Offset: 0x002BDFA4
		// (set) Token: 0x0600B05E RID: 45150 RVA: 0x000569BF File Offset: 0x00054BBF
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0600B05F RID: 45151 RVA: 0x002BFDD4 File Offset: 0x002BDFD4
		// (set) Token: 0x0600B060 RID: 45152 RVA: 0x000569DE File Offset: 0x00054BDE
		public unsafe TextMeshProUGUI ProgressLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_ProgressLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_ProgressLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0600B061 RID: 45153 RVA: 0x002BFE04 File Offset: 0x002BE004
		// (set) Token: 0x0600B062 RID: 45154 RVA: 0x000569FD File Offset: 0x00054BFD
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600B063 RID: 45155 RVA: 0x002BFE2C File Offset: 0x002BE02C
		// (set) Token: 0x0600B064 RID: 45156 RVA: 0x00056A18 File Offset: 0x00054C18
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040076BE RID: 30398
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x040076BF RID: 30399
		private static readonly IntPtr NativeFieldInfoPtr_ScreenCanvas;

		// Token: 0x040076C0 RID: 30400
		private static readonly IntPtr NativeFieldInfoPtr_OutputIcon;

		// Token: 0x040076C1 RID: 30401
		private static readonly IntPtr NativeFieldInfoPtr_QuestionMark;

		// Token: 0x040076C2 RID: 30402
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x040076C3 RID: 30403
		private static readonly IntPtr NativeFieldInfoPtr_ProgressLabel;

		// Token: 0x040076C4 RID: 30404
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040076C5 RID: 30405
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040076C6 RID: 30406
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040076C7 RID: 30407
		private static readonly IntPtr NativeMethodInfoPtr_MixingStart_Public_Virtual_Void_0;

		// Token: 0x040076C8 RID: 30408
		private static readonly IntPtr NativeMethodInfoPtr_MixingDone_Public_Virtual_Void_0;

		// Token: 0x040076C9 RID: 30409
		private static readonly IntPtr NativeMethodInfoPtr_EnableScreen_Private_Void_0;

		// Token: 0x040076CA RID: 30410
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScreen_Private_Void_0;

		// Token: 0x040076CB RID: 30411
		private static readonly IntPtr NativeMethodInfoPtr_DisableScreen_Private_Void_0;

		// Token: 0x040076CC RID: 30412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040076CD RID: 30413
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040076CE RID: 30414
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040076CF RID: 30415
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040076D0 RID: 30416
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
