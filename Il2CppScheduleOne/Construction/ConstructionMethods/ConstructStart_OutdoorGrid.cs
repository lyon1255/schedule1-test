using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x02000488 RID: 1160
	public class ConstructStart_OutdoorGrid : ConstructStart_Base
	{
		// Token: 0x06006496 RID: 25750 RVA: 0x001C6F40 File Offset: 0x001C5140
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStart_OutdoorGrid()
		{
			Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStart_OutdoorGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr);
			ConstructStart_OutdoorGrid.NativeFieldInfoPtr_constructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, "constructable");
			ConstructStart_OutdoorGrid.NativeFieldInfoPtr_ghostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, "ghostModel");
			ConstructStart_OutdoorGrid.NativeMethodInfoPtr_StartConstruction_Public_Virtual_Void_String_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, 100676044);
			ConstructStart_OutdoorGrid.NativeMethodInfoPtr_GenerateGhostModel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, 100676045);
			ConstructStart_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, 100676046);
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x001C6FD4 File Offset: 0x001C51D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204325, XrefRangeEnd = 204353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartConstruction(string constructableID, Constructable_GridBased movedConstructable = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(constructableID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(movedConstructable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructStart_OutdoorGrid.NativeMethodInfoPtr_StartConstruction_Public_Virtual_Void_String_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x001C7034 File Offset: 0x001C5234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204399, RefRangeEnd = 204400, XrefRangeStart = 204353, XrefRangeEnd = 204399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateGhostModel(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_OutdoorGrid.NativeMethodInfoPtr_GenerateGhostModel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x001C7078 File Offset: 0x001C5278
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStart_OutdoorGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x0002F8D6 File Offset: 0x0002DAD6
		public ConstructStart_OutdoorGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x0600649B RID: 25755 RVA: 0x001C70B4 File Offset: 0x001C52B4
		// (set) Token: 0x0600649C RID: 25756 RVA: 0x0002F8DF File Offset: 0x0002DADF
		public unsafe Constructable_GridBased constructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_constructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_constructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x0600649D RID: 25757 RVA: 0x001C70E4 File Offset: 0x001C52E4
		// (set) Token: 0x0600649E RID: 25758 RVA: 0x0002F8FE File Offset: 0x0002DAFE
		public unsafe Transform ghostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_ghostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_ghostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044A4 RID: 17572
		private static readonly IntPtr NativeFieldInfoPtr_constructable;

		// Token: 0x040044A5 RID: 17573
		private static readonly IntPtr NativeFieldInfoPtr_ghostModel;

		// Token: 0x040044A6 RID: 17574
		private static readonly IntPtr NativeMethodInfoPtr_StartConstruction_Public_Virtual_Void_String_Constructable_GridBased_0;

		// Token: 0x040044A7 RID: 17575
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGhostModel_Private_Void_String_0;

		// Token: 0x040044A8 RID: 17576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
