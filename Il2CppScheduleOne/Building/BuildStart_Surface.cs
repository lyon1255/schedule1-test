using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B8 RID: 1208
	public class BuildStart_Surface : BuildStart_Base
	{
		// Token: 0x060069FB RID: 27131 RVA: 0x001DA23C File Offset: 0x001D843C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_Surface()
		{
			Il2CppClassPointerStore<BuildStart_Surface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_Surface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_Surface>.NativeClassPtr);
			BuildStart_Surface.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Surface>.NativeClassPtr, 100676759);
			BuildStart_Surface.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_SurfaceItem_BuildableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Surface>.NativeClassPtr, 100676760);
			BuildStart_Surface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Surface>.NativeClassPtr, 100676761);
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x001DA2A8 File Offset: 0x001D84A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213518, XrefRangeEnd = 213553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Surface.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x001DA2F8 File Offset: 0x001D84F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213553, XrefRangeEnd = 213599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SurfaceItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Surface.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_SurfaceItem_BuildableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr3) : null;
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x001DA354 File Offset: 0x001D8554
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_Surface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_Surface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Surface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x00032109 File Offset: 0x00030309
		public BuildStart_Surface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004895 RID: 18581
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04004896 RID: 18582
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_SurfaceItem_BuildableItemDefinition_0;

		// Token: 0x04004897 RID: 18583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
