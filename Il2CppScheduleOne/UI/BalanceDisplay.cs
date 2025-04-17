using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000624 RID: 1572
	public class BalanceDisplay : MonoBehaviour
	{
		// Token: 0x06008A81 RID: 35457 RVA: 0x00244B98 File Offset: 0x00242D98
		// Note: this type is marked as 'beforefieldinit'.
		static BalanceDisplay()
		{
			Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BalanceDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr);
			BalanceDisplay.NativeFieldInfoPtr_RESIDUAL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "RESIDUAL_TIME");
			BalanceDisplay.NativeFieldInfoPtr_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "FADE_TIME");
			BalanceDisplay.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "Group");
			BalanceDisplay.NativeFieldInfoPtr_BalanceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "BalanceLabel");
			BalanceDisplay.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "<active>k__BackingField");
			BalanceDisplay.NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "<timeSinceActiveSet>k__BackingField");
			BalanceDisplay.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680507);
			BalanceDisplay.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680508);
			BalanceDisplay.NativeMethodInfoPtr_get_timeSinceActiveSet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680509);
			BalanceDisplay.NativeMethodInfoPtr_set_timeSinceActiveSet_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680510);
			BalanceDisplay.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680511);
			BalanceDisplay.NativeMethodInfoPtr_SetBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680512);
			BalanceDisplay.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680513);
			BalanceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680514);
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x06008A82 RID: 35458 RVA: 0x00244CE0 File Offset: 0x00242EE0
		// (set) Token: 0x06008A83 RID: 35459 RVA: 0x00244D1C File Offset: 0x00242F1C
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x06008A84 RID: 35460 RVA: 0x00244D5C File Offset: 0x00242F5C
		// (set) Token: 0x06008A85 RID: 35461 RVA: 0x00244D98 File Offset: 0x00242F98
		public unsafe float timeSinceActiveSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_get_timeSinceActiveSet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_set_timeSinceActiveSet_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008A86 RID: 35462 RVA: 0x00244DD8 File Offset: 0x00242FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254109, XrefRangeEnd = 254119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BalanceDisplay.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A87 RID: 35463 RVA: 0x00244E14 File Offset: 0x00243014
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 254121, RefRangeEnd = 254127, XrefRangeStart = 254119, XrefRangeEnd = 254121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBalance(float balance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref balance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_SetBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A88 RID: 35464 RVA: 0x00244E54 File Offset: 0x00243054
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254127, RefRangeEnd = 254131, XrefRangeStart = 254127, XrefRangeEnd = 254127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A89 RID: 35465 RVA: 0x00244E88 File Offset: 0x00243088
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BalanceDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x000423D3 File Offset: 0x000405D3
		public BalanceDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x06008A8B RID: 35467 RVA: 0x00244EC4 File Offset: 0x002430C4
		// (set) Token: 0x06008A8C RID: 35468 RVA: 0x000423DC File Offset: 0x000405DC
		public unsafe static float RESIDUAL_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BalanceDisplay.NativeFieldInfoPtr_RESIDUAL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BalanceDisplay.NativeFieldInfoPtr_RESIDUAL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x06008A8D RID: 35469 RVA: 0x00244EE0 File Offset: 0x002430E0
		// (set) Token: 0x06008A8E RID: 35470 RVA: 0x000423EA File Offset: 0x000405EA
		public unsafe static float FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BalanceDisplay.NativeFieldInfoPtr_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BalanceDisplay.NativeFieldInfoPtr_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x06008A8F RID: 35471 RVA: 0x00244EFC File Offset: 0x002430FC
		// (set) Token: 0x06008A90 RID: 35472 RVA: 0x000423F8 File Offset: 0x000405F8
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x06008A91 RID: 35473 RVA: 0x00244F2C File Offset: 0x0024312C
		// (set) Token: 0x06008A92 RID: 35474 RVA: 0x00042417 File Offset: 0x00040617
		public unsafe TextMeshProUGUI BalanceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_BalanceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_BalanceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x06008A93 RID: 35475 RVA: 0x00244F5C File Offset: 0x0024315C
		// (set) Token: 0x06008A94 RID: 35476 RVA: 0x00042436 File Offset: 0x00040636
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x06008A95 RID: 35477 RVA: 0x00244F84 File Offset: 0x00243184
		// (set) Token: 0x06008A96 RID: 35478 RVA: 0x00042451 File Offset: 0x00040651
		public unsafe float _timeSinceActiveSet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField)) = value;
			}
		}

		// Token: 0x04005DF6 RID: 24054
		private static readonly IntPtr NativeFieldInfoPtr_RESIDUAL_TIME;

		// Token: 0x04005DF7 RID: 24055
		private static readonly IntPtr NativeFieldInfoPtr_FADE_TIME;

		// Token: 0x04005DF8 RID: 24056
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04005DF9 RID: 24057
		private static readonly IntPtr NativeFieldInfoPtr_BalanceLabel;

		// Token: 0x04005DFA RID: 24058
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x04005DFB RID: 24059
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField;

		// Token: 0x04005DFC RID: 24060
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x04005DFD RID: 24061
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x04005DFE RID: 24062
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceActiveSet_Public_get_Single_0;

		// Token: 0x04005DFF RID: 24063
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceActiveSet_Protected_set_Void_Single_0;

		// Token: 0x04005E00 RID: 24064
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005E01 RID: 24065
		private static readonly IntPtr NativeMethodInfoPtr_SetBalance_Public_Void_Single_0;

		// Token: 0x04005E02 RID: 24066
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

		// Token: 0x04005E03 RID: 24067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
