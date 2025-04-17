using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000537 RID: 1335
	public class EquipUtility : MonoBehaviour
	{
		// Token: 0x060076BE RID: 30398 RVA: 0x00203F58 File Offset: 0x00202158
		// Note: this type is marked as 'beforefieldinit'.
		static EquipUtility()
		{
			Il2CppClassPointerStore<EquipUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "EquipUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr);
			EquipUtility.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, "Equippable");
			EquipUtility.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678250);
			EquipUtility.NativeMethodInfoPtr_Equip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678251);
			EquipUtility.NativeMethodInfoPtr_Unequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678252);
			EquipUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678253);
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x00203FEC File Offset: 0x002021EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230950, XrefRangeEnd = 230954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x00204020 File Offset: 0x00202220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230954, XrefRangeEnd = 230958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Equip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x00204054 File Offset: 0x00202254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230958, XrefRangeEnd = 230964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Unequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x00204088 File Offset: 0x00202288
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquipUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x00038445 File Offset: 0x00036645
		public EquipUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x060076C4 RID: 30404 RVA: 0x002040C4 File Offset: 0x002022C4
		// (set) Token: 0x060076C5 RID: 30405 RVA: 0x0003844E File Offset: 0x0003664E
		public unsafe AvatarEquippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipUtility.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipUtility.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005114 RID: 20756
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04005115 RID: 20757
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005116 RID: 20758
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Void_0;

		// Token: 0x04005117 RID: 20759
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Void_0;

		// Token: 0x04005118 RID: 20760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
