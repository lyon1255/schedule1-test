using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000763 RID: 1891
	public class CashStackVisuals : MonoBehaviour
	{
		// Token: 0x0600B3AA RID: 45994 RVA: 0x002CC960 File Offset: 0x002CAB60
		// Note: this type is marked as 'beforefieldinit'.
		static CashStackVisuals()
		{
			Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "CashStackVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr);
			CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "MAX_AMOUNT");
			CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Visuals_Under100");
			CashStackVisuals.NativeFieldInfoPtr_Notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Notes");
			CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Visuals_Over100");
			CashStackVisuals.NativeFieldInfoPtr_Bills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Bills");
			CashStackVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100685446);
			CashStackVisuals.NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100685447);
			CashStackVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100685448);
		}

		// Token: 0x0600B3AB RID: 45995 RVA: 0x002CCA30 File Offset: 0x002CAC30
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3AC RID: 45996 RVA: 0x002CCA64 File Offset: 0x002CAC64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308539, RefRangeEnd = 308542, XrefRangeStart = 308530, XrefRangeEnd = 308539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3AD RID: 45997 RVA: 0x002CCAA4 File Offset: 0x002CACA4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashStackVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3AE RID: 45998 RVA: 0x000580C2 File Offset: 0x000562C2
		public CashStackVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600B3AF RID: 45999 RVA: 0x002CCAE0 File Offset: 0x002CACE0
		// (set) Token: 0x0600B3B0 RID: 46000 RVA: 0x000580CB File Offset: 0x000562CB
		public unsafe static float MAX_AMOUNT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600B3B1 RID: 46001 RVA: 0x002CCAFC File Offset: 0x002CACFC
		// (set) Token: 0x0600B3B2 RID: 46002 RVA: 0x000580D9 File Offset: 0x000562D9
		public unsafe GameObject Visuals_Under100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600B3B3 RID: 46003 RVA: 0x002CCB2C File Offset: 0x002CAD2C
		// (set) Token: 0x0600B3B4 RID: 46004 RVA: 0x000580F8 File Offset: 0x000562F8
		public unsafe Il2CppReferenceArray<GameObject> Notes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Notes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Notes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600B3B5 RID: 46005 RVA: 0x002CCB5C File Offset: 0x002CAD5C
		// (set) Token: 0x0600B3B6 RID: 46006 RVA: 0x00058117 File Offset: 0x00056317
		public unsafe GameObject Visuals_Over100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600B3B7 RID: 46007 RVA: 0x002CCB8C File Offset: 0x002CAD8C
		// (set) Token: 0x0600B3B8 RID: 46008 RVA: 0x00058136 File Offset: 0x00056336
		public unsafe Il2CppReferenceArray<GameObject> Bills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Bills);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Bills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400792D RID: 31021
		private static readonly IntPtr NativeFieldInfoPtr_MAX_AMOUNT;

		// Token: 0x0400792E RID: 31022
		private static readonly IntPtr NativeFieldInfoPtr_Visuals_Under100;

		// Token: 0x0400792F RID: 31023
		private static readonly IntPtr NativeFieldInfoPtr_Notes;

		// Token: 0x04007930 RID: 31024
		private static readonly IntPtr NativeFieldInfoPtr_Visuals_Over100;

		// Token: 0x04007931 RID: 31025
		private static readonly IntPtr NativeFieldInfoPtr_Bills;

		// Token: 0x04007932 RID: 31026
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007933 RID: 31027
		private static readonly IntPtr NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0;

		// Token: 0x04007934 RID: 31028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
