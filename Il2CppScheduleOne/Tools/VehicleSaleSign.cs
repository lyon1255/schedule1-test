using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000552 RID: 1362
	public class VehicleSaleSign : MonoBehaviour
	{
		// Token: 0x06007806 RID: 30726 RVA: 0x00207B1C File Offset: 0x00205D1C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSaleSign()
		{
			Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "VehicleSaleSign");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr);
			VehicleSaleSign.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, "NameLabel");
			VehicleSaleSign.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, "PriceLabel");
			VehicleSaleSign.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, 100678390);
			VehicleSaleSign.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, 100678391);
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00207B9C File Offset: 0x00205D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232158, XrefRangeEnd = 232166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSaleSign.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00207BD0 File Offset: 0x00205DD0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSaleSign() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSaleSign.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x00038DFC File Offset: 0x00036FFC
		public VehicleSaleSign(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x00207C0C File Offset: 0x00205E0C
		// (set) Token: 0x0600780B RID: 30731 RVA: 0x00038E05 File Offset: 0x00037005
		public unsafe TextMeshPro NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x0600780C RID: 30732 RVA: 0x00207C3C File Offset: 0x00205E3C
		// (set) Token: 0x0600780D RID: 30733 RVA: 0x00038E24 File Offset: 0x00037024
		public unsafe TextMeshPro PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051D6 RID: 20950
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040051D7 RID: 20951
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x040051D8 RID: 20952
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051D9 RID: 20953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
