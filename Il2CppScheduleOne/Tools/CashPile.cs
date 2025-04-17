using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052E RID: 1326
	public class CashPile : MonoBehaviour
	{
		// Token: 0x06007650 RID: 30288 RVA: 0x00202B6C File Offset: 0x00200D6C
		// Note: this type is marked as 'beforefieldinit'.
		static CashPile()
		{
			Il2CppClassPointerStore<CashPile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CashPile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashPile>.NativeClassPtr);
			CashPile.NativeFieldInfoPtr_MAX_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "MAX_AMOUNT");
			CashPile.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "Container");
			CashPile.NativeFieldInfoPtr_CashInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "CashInstances");
			CashPile.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100678197);
			CashPile.NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100678198);
			CashPile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100678199);
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00202C14 File Offset: 0x00200E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230624, XrefRangeEnd = 230635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x00202C48 File Offset: 0x00200E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230642, RefRangeEnd = 230643, XrefRangeStart = 230635, XrefRangeEnd = 230642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00202C88 File Offset: 0x00200E88
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashPile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashPile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00038104 File Offset: 0x00036304
		public CashPile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x06007655 RID: 30293 RVA: 0x00202CC4 File Offset: 0x00200EC4
		// (set) Token: 0x06007656 RID: 30294 RVA: 0x0003810D File Offset: 0x0003630D
		public unsafe static float MAX_AMOUNT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashPile.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashPile.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x06007657 RID: 30295 RVA: 0x00202CE0 File Offset: 0x00200EE0
		// (set) Token: 0x06007658 RID: 30296 RVA: 0x0003811B File Offset: 0x0003631B
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x06007659 RID: 30297 RVA: 0x00202D10 File Offset: 0x00200F10
		// (set) Token: 0x0600765A RID: 30298 RVA: 0x0003813A File Offset: 0x0003633A
		public unsafe Il2CppReferenceArray<Transform> CashInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_CashInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_CashInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050D3 RID: 20691
		private static readonly IntPtr NativeFieldInfoPtr_MAX_AMOUNT;

		// Token: 0x040050D4 RID: 20692
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040050D5 RID: 20693
		private static readonly IntPtr NativeFieldInfoPtr_CashInstances;

		// Token: 0x040050D6 RID: 20694
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040050D7 RID: 20695
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0;

		// Token: 0x040050D8 RID: 20696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
