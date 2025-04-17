using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000737 RID: 1847
	public class Meth_Stored : StoredItem
	{
		// Token: 0x0600A8FC RID: 43260 RVA: 0x002A3218 File Offset: 0x002A1418
		// Note: this type is marked as 'beforefieldinit'.
		static Meth_Stored()
		{
			Il2CppClassPointerStore<Meth_Stored>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Meth_Stored");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Meth_Stored>.NativeClassPtr);
			Meth_Stored.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Meth_Stored>.NativeClassPtr, "Visuals");
			Meth_Stored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Meth_Stored>.NativeClassPtr, 100683998);
			Meth_Stored.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Meth_Stored>.NativeClassPtr, 100683999);
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x002A3284 File Offset: 0x002A1484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293659, XrefRangeEnd = 293669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Meth_Stored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x002A3300 File Offset: 0x002A1500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Meth_Stored() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Meth_Stored>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Meth_Stored.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8FF RID: 43263 RVA: 0x00053364 File Offset: 0x00051564
		public Meth_Stored(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600A900 RID: 43264 RVA: 0x002A333C File Offset: 0x002A153C
		// (set) Token: 0x0600A901 RID: 43265 RVA: 0x0005336D File Offset: 0x0005156D
		public unsafe MethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Meth_Stored.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Meth_Stored.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400716A RID: 29034
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400716B RID: 29035
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x0400716C RID: 29036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
