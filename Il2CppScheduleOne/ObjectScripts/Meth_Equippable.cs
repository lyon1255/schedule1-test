using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000736 RID: 1846
	public class Meth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x0600A8F6 RID: 43254 RVA: 0x002A30F0 File Offset: 0x002A12F0
		// Note: this type is marked as 'beforefieldinit'.
		static Meth_Equippable()
		{
			Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Meth_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr);
			Meth_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr, "Visuals");
			Meth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr, 100683996);
			Meth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr, 100683997);
		}

		// Token: 0x0600A8F7 RID: 43255 RVA: 0x002A315C File Offset: 0x002A135C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293649, XrefRangeEnd = 293659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Meth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F8 RID: 43256 RVA: 0x002A31AC File Offset: 0x002A13AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Meth_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Meth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x0005333C File Offset: 0x0005153C
		public Meth_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600A8FA RID: 43258 RVA: 0x002A31E8 File Offset: 0x002A13E8
		// (set) Token: 0x0600A8FB RID: 43259 RVA: 0x00053345 File Offset: 0x00051545
		public unsafe MethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Meth_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Meth_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007167 RID: 29031
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04007168 RID: 29032
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04007169 RID: 29033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
