using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000508 RID: 1288
	public class VehicleTeleporter : MonoBehaviour
	{
		// Token: 0x06007208 RID: 29192 RVA: 0x001F2DEC File Offset: 0x001F0FEC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleTeleporter()
		{
			Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "VehicleTeleporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr);
			VehicleTeleporter.NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100677589);
			VehicleTeleporter.NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100677590);
			VehicleTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100677591);
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x001F2E58 File Offset: 0x001F1058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223538, RefRangeEnd = 223539, XrefRangeStart = 223512, XrefRangeEnd = 223538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToGraph(bool resetRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x001F2E98 File Offset: 0x001F1098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223565, RefRangeEnd = 223566, XrefRangeStart = 223539, XrefRangeEnd = 223565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToRoadNetwork(bool resetRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x001F2ED8 File Offset: 0x001F10D8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleTeleporter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x00036493 File Offset: 0x00034693
		public VehicleTeleporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004DCF RID: 19919
		private static readonly IntPtr NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0;

		// Token: 0x04004DD0 RID: 19920
		private static readonly IntPtr NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0;

		// Token: 0x04004DD1 RID: 19921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
