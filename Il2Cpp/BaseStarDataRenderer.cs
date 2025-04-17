using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000022 RID: 34
	public class BaseStarDataRenderer : Il2CppSystem.Object
	{
		// Token: 0x06000295 RID: 661 RVA: 0x00078858 File Offset: 0x00076A58
		// Note: this type is marked as 'beforefieldinit'.
		static BaseStarDataRenderer()
		{
			Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BaseStarDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr);
			BaseStarDataRenderer.NativeFieldInfoPtr_progressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "progressCallback");
			BaseStarDataRenderer.NativeFieldInfoPtr_completionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "completionCallback");
			BaseStarDataRenderer.NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "density");
			BaseStarDataRenderer.NativeFieldInfoPtr_imageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "imageSize");
			BaseStarDataRenderer.NativeFieldInfoPtr_layerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "layerId");
			BaseStarDataRenderer.NativeFieldInfoPtr_maxRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "maxRadius");
			BaseStarDataRenderer.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "sphereRadius");
			BaseStarDataRenderer.NativeFieldInfoPtr_isCancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "isCancelled");
			BaseStarDataRenderer.NativeMethodInfoPtr_add_progressCallback_Public_add_Void_StarDataProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663535);
			BaseStarDataRenderer.NativeMethodInfoPtr_remove_progressCallback_Public_rem_Void_StarDataProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663536);
			BaseStarDataRenderer.NativeMethodInfoPtr_add_completionCallback_Public_add_Void_StarDataComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663537);
			BaseStarDataRenderer.NativeMethodInfoPtr_remove_completionCallback_Public_rem_Void_StarDataComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663538);
			BaseStarDataRenderer.NativeMethodInfoPtr_ComputeStarData_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663539);
			BaseStarDataRenderer.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663540);
			BaseStarDataRenderer.NativeMethodInfoPtr_SendProgress_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663541);
			BaseStarDataRenderer.NativeMethodInfoPtr_SendCompletion_Protected_Void_Texture2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663542);
			BaseStarDataRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663543);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000789DC File Offset: 0x00076BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72707, XrefRangeEnd = 72711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_progressCallback(BaseStarDataRenderer.StarDataProgress value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_add_progressCallback_Public_add_Void_StarDataProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00078A20 File Offset: 0x00076C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72711, XrefRangeEnd = 72715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_progressCallback(BaseStarDataRenderer.StarDataProgress value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_remove_progressCallback_Public_rem_Void_StarDataProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00078A64 File Offset: 0x00076C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72715, XrefRangeEnd = 72719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_completionCallback(BaseStarDataRenderer.StarDataComplete value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_add_completionCallback_Public_add_Void_StarDataComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00078AA8 File Offset: 0x00076CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72719, XrefRangeEnd = 72723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_completionCallback(BaseStarDataRenderer.StarDataComplete value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_remove_completionCallback_Public_rem_Void_StarDataComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00078AEC File Offset: 0x00076CEC
		[CallerCount(0)]
		public unsafe virtual IEnumerator ComputeStarData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStarDataRenderer.NativeMethodInfoPtr_ComputeStarData_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00078B38 File Offset: 0x00076D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72723, XrefRangeEnd = 72725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStarDataRenderer.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00078B74 File Offset: 0x00076D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72725, RefRangeEnd = 72726, XrefRangeStart = 72725, XrefRangeEnd = 72725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_SendProgress_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00078BB4 File Offset: 0x00076DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72726, RefRangeEnd = 72727, XrefRangeStart = 72726, XrefRangeEnd = 72726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCompletion(Texture2D texture, bool success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_SendCompletion_Protected_Void_Texture2D_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00078C04 File Offset: 0x00076E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72728, RefRangeEnd = 72729, XrefRangeStart = 72727, XrefRangeEnd = 72728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseStarDataRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000376A File Offset: 0x0000196A
		public BaseStarDataRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00078C40 File Offset: 0x00076E40
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00003773 File Offset: 0x00001973
		public unsafe BaseStarDataRenderer.StarDataProgress progressCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_progressCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseStarDataRenderer.StarDataProgress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_progressCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00078C70 File Offset: 0x00076E70
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00003792 File Offset: 0x00001992
		public unsafe BaseStarDataRenderer.StarDataComplete completionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_completionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseStarDataRenderer.StarDataComplete>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_completionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00078CA0 File Offset: 0x00076EA0
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x000037B1 File Offset: 0x000019B1
		public unsafe float density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_density);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_density)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00078CC8 File Offset: 0x00076EC8
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x000037CC File Offset: 0x000019CC
		public unsafe float imageSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_imageSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_imageSize)) = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00078CF0 File Offset: 0x00076EF0
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x000037E7 File Offset: 0x000019E7
		public unsafe string layerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_layerId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_layerId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00078D18 File Offset: 0x00076F18
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00003806 File Offset: 0x00001A06
		public unsafe float maxRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_maxRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_maxRadius)) = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00078D40 File Offset: 0x00076F40
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00003821 File Offset: 0x00001A21
		public unsafe float sphereRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_sphereRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_sphereRadius)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00078D68 File Offset: 0x00076F68
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000383C File Offset: 0x00001A3C
		public unsafe bool isCancelled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_isCancelled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_isCancelled)) = value;
			}
		}

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_progressCallback;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_completionCallback;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_density;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_imageSize;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_layerId;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_maxRadius;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeFieldInfoPtr_isCancelled;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_add_progressCallback_Public_add_Void_StarDataProgress_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_remove_progressCallback_Public_rem_Void_StarDataProgress_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_add_completionCallback_Public_add_Void_StarDataComplete_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_remove_completionCallback_Public_rem_Void_StarDataComplete_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_ComputeStarData_Public_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_SendProgress_Protected_Void_Single_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_SendCompletion_Protected_Void_Texture2D_Boolean_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020007AC RID: 1964
		public sealed class StarDataProgress : MulticastDelegate
		{
			// Token: 0x0600B96B RID: 47467 RVA: 0x002E07DC File Offset: 0x002DE9DC
			// Note: this type is marked as 'beforefieldinit'.
			static StarDataProgress()
			{
				Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "StarDataProgress");
				BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr, 100663544);
				BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr, 100663545);
				BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr, 100663546);
				BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr, 100663547);
			}

			// Token: 0x0600B96C RID: 47468 RVA: 0x002E0850 File Offset: 0x002DEA50
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 72687, RefRangeEnd = 72689, XrefRangeStart = 72678, XrefRangeEnd = 72687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StarDataProgress(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B96D RID: 47469 RVA: 0x002E08AC File Offset: 0x002DEAAC
			[CallerCount(0)]
			public unsafe void Invoke(BaseStarDataRenderer renderer, float progress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B96E RID: 47470 RVA: 0x002E08FC File Offset: 0x002DEAFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72689, XrefRangeEnd = 72693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(BaseStarDataRenderer renderer, float progress, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600B96F RID: 47471 RVA: 0x002E0980 File Offset: 0x002DEB80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B970 RID: 47472 RVA: 0x0005AA70 File Offset: 0x00058C70
			public StarDataProgress(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B971 RID: 47473 RVA: 0x0005AA79 File Offset: 0x00058C79
			public static implicit operator BaseStarDataRenderer.StarDataProgress(Action<BaseStarDataRenderer, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<BaseStarDataRenderer.StarDataProgress>(A_0);
			}

			// Token: 0x0600B972 RID: 47474 RVA: 0x0005AA81 File Offset: 0x00058C81
			public static BaseStarDataRenderer.StarDataProgress operator +(BaseStarDataRenderer.StarDataProgress A_0, BaseStarDataRenderer.StarDataProgress A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BaseStarDataRenderer.StarDataProgress>();
			}

			// Token: 0x0600B973 RID: 47475 RVA: 0x0005AA8F File Offset: 0x00058C8F
			public static BaseStarDataRenderer.StarDataProgress operator -(BaseStarDataRenderer.StarDataProgress A_0, BaseStarDataRenderer.StarDataProgress A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<BaseStarDataRenderer.StarDataProgress>();
				}
				return result;
			}

			// Token: 0x04007D1B RID: 32027
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04007D1C RID: 32028
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Single_0;

			// Token: 0x04007D1D RID: 32029
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Single_AsyncCallback_Object_0;

			// Token: 0x04007D1E RID: 32030
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020007AD RID: 1965
		public sealed class StarDataComplete : MulticastDelegate
		{
			// Token: 0x0600B974 RID: 47476 RVA: 0x002E09C4 File Offset: 0x002DEBC4
			// Note: this type is marked as 'beforefieldinit'.
			static StarDataComplete()
			{
				Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "StarDataComplete");
				BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr, 100663548);
				BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Texture2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr, 100663549);
				BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Texture2D_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr, 100663550);
				BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr, 100663551);
			}

			// Token: 0x0600B975 RID: 47477 RVA: 0x002E0A38 File Offset: 0x002DEC38
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72702, RefRangeEnd = 72703, XrefRangeStart = 72693, XrefRangeEnd = 72702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StarDataComplete(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B976 RID: 47478 RVA: 0x002E0A94 File Offset: 0x002DEC94
			[CallerCount(0)]
			public unsafe void Invoke(BaseStarDataRenderer renderer, Texture2D texture, bool success)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Texture2D_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B977 RID: 47479 RVA: 0x002E0AF8 File Offset: 0x002DECF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72703, XrefRangeEnd = 72707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(BaseStarDataRenderer renderer, Texture2D texture, bool success, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Texture2D_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600B978 RID: 47480 RVA: 0x002E0B90 File Offset: 0x002DED90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B979 RID: 47481 RVA: 0x0005AAA0 File Offset: 0x00058CA0
			public StarDataComplete(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B97A RID: 47482 RVA: 0x0005AAA9 File Offset: 0x00058CA9
			public static implicit operator BaseStarDataRenderer.StarDataComplete(Action<BaseStarDataRenderer, Texture2D, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<BaseStarDataRenderer.StarDataComplete>(A_0);
			}

			// Token: 0x0600B97B RID: 47483 RVA: 0x0005AAB1 File Offset: 0x00058CB1
			public static BaseStarDataRenderer.StarDataComplete operator +(BaseStarDataRenderer.StarDataComplete A_0, BaseStarDataRenderer.StarDataComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BaseStarDataRenderer.StarDataComplete>();
			}

			// Token: 0x0600B97C RID: 47484 RVA: 0x0005AABF File Offset: 0x00058CBF
			public static BaseStarDataRenderer.StarDataComplete operator -(BaseStarDataRenderer.StarDataComplete A_0, BaseStarDataRenderer.StarDataComplete A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<BaseStarDataRenderer.StarDataComplete>();
				}
				return result;
			}

			// Token: 0x04007D1F RID: 32031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04007D20 RID: 32032
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Texture2D_Boolean_0;

			// Token: 0x04007D21 RID: 32033
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Texture2D_Boolean_AsyncCallback_Object_0;

			// Token: 0x04007D22 RID: 32034
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
