using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000762 RID: 1890
	public class Cash : MonoBehaviour
	{
		// Token: 0x0600B3A2 RID: 45986 RVA: 0x002CC820 File Offset: 0x002CAA20
		// Note: this type is marked as 'beforefieldinit'.
		static Cash()
		{
			Il2CppClassPointerStore<Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cash>.NativeClassPtr);
			Cash.NativeFieldInfoPtr_stackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cash>.NativeClassPtr, "stackSize");
			Cash.NativeFieldInfoPtr_amounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cash>.NativeClassPtr, "amounts");
			Cash.NativeMethodInfoPtr_GetBillStacksToDisplay_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cash>.NativeClassPtr, 100685443);
			Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cash>.NativeClassPtr, 100685444);
		}

		// Token: 0x0600B3A3 RID: 45987 RVA: 0x002CC8A0 File Offset: 0x002CAAA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308529, RefRangeEnd = 308530, XrefRangeStart = 308529, XrefRangeEnd = 308529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetBillStacksToDisplay(float amount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cash.NativeMethodInfoPtr_GetBillStacksToDisplay_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B3A4 RID: 45988 RVA: 0x002CC8E0 File Offset: 0x002CAAE0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x00058099 File Offset: 0x00056299
		public Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600B3A6 RID: 45990 RVA: 0x002CC91C File Offset: 0x002CAB1C
		// (set) Token: 0x0600B3A7 RID: 45991 RVA: 0x000580A2 File Offset: 0x000562A2
		public unsafe static float stackSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Cash.NativeFieldInfoPtr_stackSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cash.NativeFieldInfoPtr_stackSize, (void*)(&value));
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600B3A8 RID: 45992 RVA: 0x002CC938 File Offset: 0x002CAB38
		// (set) Token: 0x0600B3A9 RID: 45993 RVA: 0x000580B0 File Offset: 0x000562B0
		public unsafe static Il2CppStructArray<int> amounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cash.NativeFieldInfoPtr_amounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cash.NativeFieldInfoPtr_amounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007929 RID: 31017
		private static readonly IntPtr NativeFieldInfoPtr_stackSize;

		// Token: 0x0400792A RID: 31018
		private static readonly IntPtr NativeFieldInfoPtr_amounts;

		// Token: 0x0400792B RID: 31019
		private static readonly IntPtr NativeMethodInfoPtr_GetBillStacksToDisplay_Public_Static_Int32_Single_0;

		// Token: 0x0400792C RID: 31020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
