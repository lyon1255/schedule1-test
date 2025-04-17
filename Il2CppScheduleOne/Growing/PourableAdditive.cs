using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055C RID: 1372
	public class PourableAdditive : Pourable
	{
		// Token: 0x060078A4 RID: 30884 RVA: 0x002096D4 File Offset: 0x002078D4
		// Note: this type is marked as 'beforefieldinit'.
		static PourableAdditive()
		{
			Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PourableAdditive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr);
			PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "NormalizedAmountForSuccess");
			PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "AdditiveDefinition");
			PourableAdditive.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "LiquidColor");
			PourableAdditive.NativeFieldInfoPtr_pouredAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "pouredAmount");
			PourableAdditive.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, 100678430);
			PourableAdditive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, 100678431);
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x0020977C File Offset: 0x0020797C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232515, XrefRangeEnd = 232516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableAdditive.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x002097C8 File Offset: 0x002079C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232516, XrefRangeEnd = 232517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableAdditive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAdditive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x000393FD File Offset: 0x000375FD
		public PourableAdditive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x060078A8 RID: 30888 RVA: 0x00209804 File Offset: 0x00207A04
		// (set) Token: 0x060078A9 RID: 30889 RVA: 0x00039406 File Offset: 0x00037606
		public unsafe static float NormalizedAmountForSuccess
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess, (void*)(&value));
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x060078AA RID: 30890 RVA: 0x00209820 File Offset: 0x00207A20
		// (set) Token: 0x060078AB RID: 30891 RVA: 0x00039414 File Offset: 0x00037614
		public unsafe AdditiveDefinition AdditiveDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x060078AC RID: 30892 RVA: 0x00209850 File Offset: 0x00207A50
		// (set) Token: 0x060078AD RID: 30893 RVA: 0x00039433 File Offset: 0x00037633
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x060078AE RID: 30894 RVA: 0x00209878 File Offset: 0x00207A78
		// (set) Token: 0x060078AF RID: 30895 RVA: 0x0003944E File Offset: 0x0003764E
		public unsafe float pouredAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_pouredAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_pouredAmount)) = value;
			}
		}

		// Token: 0x0400522F RID: 21039
		private static readonly IntPtr NativeFieldInfoPtr_NormalizedAmountForSuccess;

		// Token: 0x04005230 RID: 21040
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveDefinition;

		// Token: 0x04005231 RID: 21041
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x04005232 RID: 21042
		private static readonly IntPtr NativeFieldInfoPtr_pouredAmount;

		// Token: 0x04005233 RID: 21043
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04005234 RID: 21044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
