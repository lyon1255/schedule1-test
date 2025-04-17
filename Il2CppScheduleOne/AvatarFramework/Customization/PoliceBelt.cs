using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200060F RID: 1551
	public class PoliceBelt : Accessory
	{
		// Token: 0x06008938 RID: 35128 RVA: 0x00240D38 File Offset: 0x0023EF38
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceBelt()
		{
			Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "PoliceBelt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr);
			PoliceBelt.NativeFieldInfoPtr_BatonObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "BatonObject");
			PoliceBelt.NativeFieldInfoPtr_TaserObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "TaserObject");
			PoliceBelt.NativeFieldInfoPtr_GunObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "GunObject");
			PoliceBelt.NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680378);
			PoliceBelt.NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680379);
			PoliceBelt.NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680380);
			PoliceBelt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680381);
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x00240DF4 File Offset: 0x0023EFF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253115, RefRangeEnd = 253118, XrefRangeStart = 253112, XrefRangeEnd = 253115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBatonVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x00240E34 File Offset: 0x0023F034
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253121, RefRangeEnd = 253124, XrefRangeStart = 253118, XrefRangeEnd = 253121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTaserVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600893B RID: 35131 RVA: 0x00240E74 File Offset: 0x0023F074
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253127, RefRangeEnd = 253130, XrefRangeStart = 253124, XrefRangeEnd = 253127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGunVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600893C RID: 35132 RVA: 0x00240EB4 File Offset: 0x0023F0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253130, XrefRangeEnd = 253131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceBelt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600893D RID: 35133 RVA: 0x00041870 File Offset: 0x0003FA70
		public PoliceBelt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x0600893E RID: 35134 RVA: 0x00240EF0 File Offset: 0x0023F0F0
		// (set) Token: 0x0600893F RID: 35135 RVA: 0x00041879 File Offset: 0x0003FA79
		public unsafe GameObject BatonObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_BatonObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_BatonObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x06008940 RID: 35136 RVA: 0x00240F20 File Offset: 0x0023F120
		// (set) Token: 0x06008941 RID: 35137 RVA: 0x00041898 File Offset: 0x0003FA98
		public unsafe GameObject TaserObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_TaserObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_TaserObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x06008942 RID: 35138 RVA: 0x00240F50 File Offset: 0x0023F150
		// (set) Token: 0x06008943 RID: 35139 RVA: 0x000418B7 File Offset: 0x0003FAB7
		public unsafe GameObject GunObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_GunObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_GunObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D30 RID: 23856
		private static readonly IntPtr NativeFieldInfoPtr_BatonObject;

		// Token: 0x04005D31 RID: 23857
		private static readonly IntPtr NativeFieldInfoPtr_TaserObject;

		// Token: 0x04005D32 RID: 23858
		private static readonly IntPtr NativeFieldInfoPtr_GunObject;

		// Token: 0x04005D33 RID: 23859
		private static readonly IntPtr NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0;

		// Token: 0x04005D34 RID: 23860
		private static readonly IntPtr NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0;

		// Token: 0x04005D35 RID: 23861
		private static readonly IntPtr NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0;

		// Token: 0x04005D36 RID: 23862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
