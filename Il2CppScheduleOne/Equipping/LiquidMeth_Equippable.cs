using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005B7 RID: 1463
	public class LiquidMeth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x0600807E RID: 32894 RVA: 0x00225764 File Offset: 0x00223964
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMeth_Equippable()
		{
			Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "LiquidMeth_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr);
			LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, "Visuals");
			LiquidMeth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, 100679423);
			LiquidMeth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, 100679424);
		}

		// Token: 0x0600807F RID: 32895 RVA: 0x002257D0 File Offset: 0x002239D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244260, XrefRangeEnd = 244271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidMeth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008080 RID: 32896 RVA: 0x00225820 File Offset: 0x00223A20
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244274, RefRangeEnd = 244282, XrefRangeStart = 244271, XrefRangeEnd = 244274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMeth_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMeth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008081 RID: 32897 RVA: 0x0003CF70 File Offset: 0x0003B170
		public LiquidMeth_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x06008082 RID: 32898 RVA: 0x0022585C File Offset: 0x00223A5C
		// (set) Token: 0x06008083 RID: 32899 RVA: 0x0003CF79 File Offset: 0x0003B179
		public unsafe LiquidMethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidMethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005786 RID: 22406
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005787 RID: 22407
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005788 RID: 22408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
