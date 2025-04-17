using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073E RID: 1854
	public class BunsenBurner : MonoBehaviour
	{
		// Token: 0x0600AB14 RID: 43796 RVA: 0x002AB68C File Offset: 0x002A988C
		// Note: this type is marked as 'beforefieldinit'.
		static BunsenBurner()
		{
			Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BunsenBurner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr);
			BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<Interactable>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<IsDialHeld>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<CurrentDialValue>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<CurrentHeat>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr_LockDial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "LockDial");
			BunsenBurner.NativeFieldInfoPtr_FlameColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlameColor");
			BunsenBurner.NativeFieldInfoPtr_LightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "LightIntensity");
			BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "HandleRotationSpeed");
			BunsenBurner.NativeFieldInfoPtr_FlamePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlamePitch");
			BunsenBurner.NativeFieldInfoPtr_Flame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Flame");
			BunsenBurner.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Light");
			BunsenBurner.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle");
			BunsenBurner.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "HandleClickable");
			BunsenBurner.NativeFieldInfoPtr_Handle_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle_Min");
			BunsenBurner.NativeFieldInfoPtr_Handle_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle_Max");
			BunsenBurner.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Highlight");
			BunsenBurner.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Anim");
			BunsenBurner.NativeFieldInfoPtr_FlameSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlameSound");
			BunsenBurner.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684290);
			BunsenBurner.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684291);
			BunsenBurner.NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684292);
			BunsenBurner.NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684293);
			BunsenBurner.NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684294);
			BunsenBurner.NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684295);
			BunsenBurner.NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684296);
			BunsenBurner.NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684297);
			BunsenBurner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684298);
			BunsenBurner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684299);
			BunsenBurner.NativeMethodInfoPtr_UpdateEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684300);
			BunsenBurner.NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684301);
			BunsenBurner.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684302);
			BunsenBurner.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684303);
			BunsenBurner.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684304);
			BunsenBurner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684305);
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600AB15 RID: 43797 RVA: 0x002AB964 File Offset: 0x002A9B64
		// (set) Token: 0x0600AB16 RID: 43798 RVA: 0x002AB9A0 File Offset: 0x002A9BA0
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600AB17 RID: 43799 RVA: 0x002AB9E0 File Offset: 0x002A9BE0
		// (set) Token: 0x0600AB18 RID: 43800 RVA: 0x002ABA1C File Offset: 0x002A9C1C
		public unsafe bool IsDialHeld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600AB19 RID: 43801 RVA: 0x002ABA5C File Offset: 0x002A9C5C
		// (set) Token: 0x0600AB1A RID: 43802 RVA: 0x002ABA98 File Offset: 0x002A9C98
		public unsafe float CurrentDialValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29987, XrefRangeStart = 29976, XrefRangeEnd = 29987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600AB1B RID: 43803 RVA: 0x002ABAD8 File Offset: 0x002A9CD8
		// (set) Token: 0x0600AB1C RID: 43804 RVA: 0x002ABB14 File Offset: 0x002A9D14
		public unsafe float CurrentHeat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AB1D RID: 43805 RVA: 0x002ABB54 File Offset: 0x002A9D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296844, XrefRangeEnd = 296864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB1E RID: 43806 RVA: 0x002ABB88 File Offset: 0x002A9D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296864, XrefRangeEnd = 296882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB1F RID: 43807 RVA: 0x002ABBBC File Offset: 0x002A9DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296897, RefRangeEnd = 296898, XrefRangeStart = 296882, XrefRangeEnd = 296897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_UpdateEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x002ABBF0 File Offset: 0x002A9DF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 296903, RefRangeEnd = 296907, XrefRangeStart = 296898, XrefRangeEnd = 296903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDialPosition(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB21 RID: 43809 RVA: 0x002ABC30 File Offset: 0x002A9E30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 296910, RefRangeEnd = 296913, XrefRangeStart = 296907, XrefRangeEnd = 296910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB22 RID: 43810 RVA: 0x002ABC70 File Offset: 0x002A9E70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 216799, RefRangeEnd = 216803, XrefRangeStart = 216799, XrefRangeEnd = 216803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB23 RID: 43811 RVA: 0x002ABCB0 File Offset: 0x002A9EB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216803, RefRangeEnd = 216805, XrefRangeStart = 216803, XrefRangeEnd = 216805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB24 RID: 43812 RVA: 0x002ABCE4 File Offset: 0x002A9EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296913, XrefRangeEnd = 296914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunsenBurner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x000542F1 File Offset: 0x000524F1
		public BunsenBurner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600AB26 RID: 43814 RVA: 0x002ABD20 File Offset: 0x002A9F20
		// (set) Token: 0x0600AB27 RID: 43815 RVA: 0x000542FA File Offset: 0x000524FA
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600AB28 RID: 43816 RVA: 0x002ABD48 File Offset: 0x002A9F48
		// (set) Token: 0x0600AB29 RID: 43817 RVA: 0x00054315 File Offset: 0x00052515
		public unsafe bool _IsDialHeld_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField)) = value;
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600AB2A RID: 43818 RVA: 0x002ABD70 File Offset: 0x002A9F70
		// (set) Token: 0x0600AB2B RID: 43819 RVA: 0x00054330 File Offset: 0x00052530
		public unsafe float _CurrentDialValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600AB2C RID: 43820 RVA: 0x002ABD98 File Offset: 0x002A9F98
		// (set) Token: 0x0600AB2D RID: 43821 RVA: 0x0005434B File Offset: 0x0005254B
		public unsafe float _CurrentHeat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField)) = value;
			}
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600AB2E RID: 43822 RVA: 0x002ABDC0 File Offset: 0x002A9FC0
		// (set) Token: 0x0600AB2F RID: 43823 RVA: 0x00054366 File Offset: 0x00052566
		public unsafe bool LockDial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LockDial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LockDial)) = value;
			}
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600AB30 RID: 43824 RVA: 0x002ABDE8 File Offset: 0x002A9FE8
		// (set) Token: 0x0600AB31 RID: 43825 RVA: 0x00054381 File Offset: 0x00052581
		public unsafe Gradient FlameColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600AB32 RID: 43826 RVA: 0x002ABE18 File Offset: 0x002AA018
		// (set) Token: 0x0600AB33 RID: 43827 RVA: 0x000543A0 File Offset: 0x000525A0
		public unsafe AnimationCurve LightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LightIntensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LightIntensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600AB34 RID: 43828 RVA: 0x002ABE48 File Offset: 0x002AA048
		// (set) Token: 0x0600AB35 RID: 43829 RVA: 0x000543BF File Offset: 0x000525BF
		public unsafe float HandleRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed)) = value;
			}
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600AB36 RID: 43830 RVA: 0x002ABE70 File Offset: 0x002AA070
		// (set) Token: 0x0600AB37 RID: 43831 RVA: 0x000543DA File Offset: 0x000525DA
		public unsafe AnimationCurve FlamePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlamePitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlamePitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600AB38 RID: 43832 RVA: 0x002ABEA0 File Offset: 0x002AA0A0
		// (set) Token: 0x0600AB39 RID: 43833 RVA: 0x000543F9 File Offset: 0x000525F9
		public unsafe ParticleSystem Flame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Flame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Flame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600AB3A RID: 43834 RVA: 0x002ABED0 File Offset: 0x002AA0D0
		// (set) Token: 0x0600AB3B RID: 43835 RVA: 0x00054418 File Offset: 0x00052618
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600AB3C RID: 43836 RVA: 0x002ABF00 File Offset: 0x002AA100
		// (set) Token: 0x0600AB3D RID: 43837 RVA: 0x00054437 File Offset: 0x00052637
		public unsafe Transform Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600AB3E RID: 43838 RVA: 0x002ABF30 File Offset: 0x002AA130
		// (set) Token: 0x0600AB3F RID: 43839 RVA: 0x00054456 File Offset: 0x00052656
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600AB40 RID: 43840 RVA: 0x002ABF60 File Offset: 0x002AA160
		// (set) Token: 0x0600AB41 RID: 43841 RVA: 0x00054475 File Offset: 0x00052675
		public unsafe Transform Handle_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600AB42 RID: 43842 RVA: 0x002ABF90 File Offset: 0x002AA190
		// (set) Token: 0x0600AB43 RID: 43843 RVA: 0x00054494 File Offset: 0x00052694
		public unsafe Transform Handle_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600AB44 RID: 43844 RVA: 0x002ABFC0 File Offset: 0x002AA1C0
		// (set) Token: 0x0600AB45 RID: 43845 RVA: 0x000544B3 File Offset: 0x000526B3
		public unsafe Transform Highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600AB46 RID: 43846 RVA: 0x002ABFF0 File Offset: 0x002AA1F0
		// (set) Token: 0x0600AB47 RID: 43847 RVA: 0x000544D2 File Offset: 0x000526D2
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600AB48 RID: 43848 RVA: 0x002AC020 File Offset: 0x002AA220
		// (set) Token: 0x0600AB49 RID: 43849 RVA: 0x000544F1 File Offset: 0x000526F1
		public unsafe AudioSourceController FlameSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040072F1 RID: 29425
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040072F2 RID: 29426
		private static readonly IntPtr NativeFieldInfoPtr__IsDialHeld_k__BackingField;

		// Token: 0x040072F3 RID: 29427
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDialValue_k__BackingField;

		// Token: 0x040072F4 RID: 29428
		private static readonly IntPtr NativeFieldInfoPtr__CurrentHeat_k__BackingField;

		// Token: 0x040072F5 RID: 29429
		private static readonly IntPtr NativeFieldInfoPtr_LockDial;

		// Token: 0x040072F6 RID: 29430
		private static readonly IntPtr NativeFieldInfoPtr_FlameColor;

		// Token: 0x040072F7 RID: 29431
		private static readonly IntPtr NativeFieldInfoPtr_LightIntensity;

		// Token: 0x040072F8 RID: 29432
		private static readonly IntPtr NativeFieldInfoPtr_HandleRotationSpeed;

		// Token: 0x040072F9 RID: 29433
		private static readonly IntPtr NativeFieldInfoPtr_FlamePitch;

		// Token: 0x040072FA RID: 29434
		private static readonly IntPtr NativeFieldInfoPtr_Flame;

		// Token: 0x040072FB RID: 29435
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x040072FC RID: 29436
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x040072FD RID: 29437
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x040072FE RID: 29438
		private static readonly IntPtr NativeFieldInfoPtr_Handle_Min;

		// Token: 0x040072FF RID: 29439
		private static readonly IntPtr NativeFieldInfoPtr_Handle_Max;

		// Token: 0x04007300 RID: 29440
		private static readonly IntPtr NativeFieldInfoPtr_Highlight;

		// Token: 0x04007301 RID: 29441
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04007302 RID: 29442
		private static readonly IntPtr NativeFieldInfoPtr_FlameSound;

		// Token: 0x04007303 RID: 29443
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04007304 RID: 29444
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x04007305 RID: 29445
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0;

		// Token: 0x04007306 RID: 29446
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0;

		// Token: 0x04007307 RID: 29447
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0;

		// Token: 0x04007308 RID: 29448
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0;

		// Token: 0x04007309 RID: 29449
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0;

		// Token: 0x0400730A RID: 29450
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0;

		// Token: 0x0400730B RID: 29451
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400730C RID: 29452
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400730D RID: 29453
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_0;

		// Token: 0x0400730E RID: 29454
		private static readonly IntPtr NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0;

		// Token: 0x0400730F RID: 29455
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007310 RID: 29456
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04007311 RID: 29457
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04007312 RID: 29458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
