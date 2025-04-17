using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B6 RID: 1206
	public class BuildStart_ProceduralGrid : BuildStart_Base
	{
		// Token: 0x060069F1 RID: 27121 RVA: 0x001D9F94 File Offset: 0x001D8194
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_ProceduralGrid()
		{
			Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_ProceduralGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr);
			BuildStart_ProceduralGrid.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr, 100676753);
			BuildStart_ProceduralGrid.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_ProceduralGridItem_BuildableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr, 100676754);
			BuildStart_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr, 100676755);
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x001DA000 File Offset: 0x001D8200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213379, XrefRangeEnd = 213422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_ProceduralGrid.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x001DA050 File Offset: 0x001D8250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213422, XrefRangeEnd = 213455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ProceduralGridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_ProceduralGrid.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_ProceduralGridItem_BuildableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr3) : null;
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x001DA0AC File Offset: 0x001D82AC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_ProceduralGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x000320F7 File Offset: 0x000302F7
		public BuildStart_ProceduralGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400488F RID: 18575
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04004890 RID: 18576
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_ProceduralGridItem_BuildableItemDefinition_0;

		// Token: 0x04004891 RID: 18577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
